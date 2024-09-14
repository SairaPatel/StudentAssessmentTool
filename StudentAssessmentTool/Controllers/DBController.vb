Imports System.Data.SqlClient
' I used the following website to help me with any SQL syntax that I did not know
' https://www.w3schools.com/sql/default.asp


Public Class DBController
    Property connectionString As String
    Property projectPath As String
    Sub New()
        ' set connection string 
        projectPath = Application.StartupPath.Substring(0, Application.StartupPath.Length - "/bin/Debug".Length)
        connectionString = $"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='{projectPath}\AssessmentToolDatabase.mdf';Integrated Security=True"

        ' the below statments were only executed once:
        'createAllTables()
        'modifyPartsCorrectAnswer()
    End Sub

#Region "Execution"

    Public Sub NonQueryCommand(statement As String)
        ' execute a non query operation (i.e. INSERT, DELETE, CREATE, UPDATE..)
        Try
            ' open connection
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                'execute command
                Using command As New SqlCommand(statement, conn)
                    command.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using

        Catch ex As Exception ' catch exceptions
            MessageBox.Show("Error (Non Query Command Function) : " & ex.Message)
        End Try

    End Sub

    Public Function QueryCommand(statement As String) As List(Of Object())
        ' execute a query (i.e. SELECT)
        Dim results As New List(Of Object())
        Try
            ' open connection
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                ' get results
                Using command As New SqlCommand(statement, conn)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        Dim columns As Integer = reader.VisibleFieldCount

                        ' read each record
                        While reader.Read()
                            Dim record(columns - 1) As Object

                            ' get each attribute of the record
                            For i = 0 To columns - 1
                                ' convert to appropriate datatype
                                Select Case reader.GetDataTypeName(i)
                                    Case "varchar"
                                        record(i) = reader.GetString(i)
                                    Case "int"
                                        record(i) = reader.GetInt32(i).ToString()
                                    Case Else
                                        MessageBox.Show("Unknown datatype: " & reader.GetDataTypeName(i))

                                End Select
                            Next
                            results.Add(record)
                        End While

                        reader.Close()
                    End Using
                    conn.Close()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("There was an error updating or retrieving your data. An operation could not be performed.")
        End Try

        Return results
    End Function

#End Region

#Region "Table Structures"
    Private Sub createAllTables()

        'create all tables (executed only once)
        createTableTeachers()
        createTableAssessments()
        createTableTeacherAccess()
        createTableQuestions()
        createTableParts()

        createTableReports()
        createTableStudents()
        createTableStudentAnswers()

        createTableStudentUsers()
        createTableStudentReports()
    End Sub

    Public Sub createTableTeachers()
        ' TEACHERS
        Dim command As String
        command = "CREATE TABLE Teachers(
            UserID int IDENTITY(1,1) PRIMARY KEY,
            Username varchar(40) NOT NULL,
            Password varchar(40) NOT NULL,
            ); "
        NonQueryCommand(command)
    End Sub

    Public Sub createTableAssessments()
        ' ASSESSMENTS
        Dim command As String
        command = "CREATE TABLE Assessments(
            AssessmentID varchar(50) PRIMARY KEY,
            UserID int FOREIGN KEY REFERENCES Teachers(UserID),
            Name varchar(100) NOT NULL,
            AllowedType varchar(30),
            ); "
        NonQueryCommand(command)
    End Sub

    Public Sub createTableTeacherAccess()

        ' TEACHER ACCESS 
        Dim command As String
        command = "CREATE TABLE TeacherAccess(
            AssessmentID varchar(50) FOREIGN KEY REFERENCES Assessments(AssessmentID) ON DELETE CASCADE,
            UserID int FOREIGN KEY REFERENCES Teachers(UserID) ON DELETE CASCADE,
            CONSTRAINT TeacherAccessPK PRIMARY KEY (AssessmentID, UserID)
            ); "
        NonQueryCommand(command)
    End Sub

    Public Sub createTableQuestions()
        ' QUESTIONS 
        Dim command As String
        command = "CREATE TABLE Questions(
            AssessmentID varchar(50) FOREIGN KEY REFERENCES Assessments(AssessmentID) ON DELETE CASCADE,
            QuestionNumber int,
            Category varchar(50),
            Timer int,
            CONSTRAINT QuestionPK PRIMARY KEY (AssessmentID, QuestionNumber)
            ); "

        NonQueryCommand(command)
    End Sub

    Public Sub createTableParts()
        ' PARTS 
        Dim command As String
        command = "CREATE TABLE Parts(
            PartID int,
            QuestionNumber int,
            AssessmentID varchar(50),
            QuestionType varchar(40),
            QuestionText varchar(1000),
            Answer1 varchar(250),
            Answer2 varchar(250),
            Answer3 varchar(250),
            Answer4 varchar(250),
            Answer5 varchar(250),
            Answer6 varchar(250),
            CorrectAnswer int,
            AvailableMarks int,
            CONSTRAINT QuestionID FOREIGN KEY (AssessmentID, QuestionNumber) REFERENCES Questions(AssessmentID, QuestionNumber) ON DELETE CASCADE,
            CONSTRAINT PartsPK PRIMARY KEY (PartID, QuestionNumber, AssessmentID),
            ); "
        NonQueryCommand(command)
    End Sub

    Public Sub modifyPartsCorrectAnswer()
        ' originally CorrectAnswer was an integer: it is used to store the index of the correct answer
        ' however for Multiple answer questions, sometimes there are multiple correct answers which are concatonated as a string (e.g. 124)
        ' storing this as a string does not work when one of the answers is at index 0 - e.g ('0124' since this would be converted to 124 and '0' would be missed)

        ' the following code updates the Parts table so that CorrectAnswer is a varchar
        Dim command As String
        command = "ALTER TABLE Parts
                        ALTER COLUMN CorrectAnswer varchar(10);"

        NonQueryCommand(command)
    End Sub

    Public Sub createTableReports()
        ' REPORTS
        Dim command As String
        command = "CREATE TABLE Reports(
            ReportID varchar(50) PRIMARY KEY,
            AssessmentID varchar(50) FOREIGN KEY REFERENCES Assessments(AssessmentID) ON DELETE CASCADE,
            Name varchar(100) NOT NULL,
            ); "
        NonQueryCommand(command)
    End Sub

    Public Sub createTableStudents()
        ' STUDENTS
        Dim command As String
        command = "CREATE TABLE Students(
            StudentID int IDENTITY(1,1) PRIMARY KEY,
            ReportID varchar(50) FOREIGN KEY REFERENCES Reports(ReportID) ON DELETE CASCADE,
            Name varchar(60) NOT NULL,
            ); "
        NonQueryCommand(command)
    End Sub
    Public Sub createTableStudentAnswers()
        ' STUDENTS ANSWERS
        Dim command As String
        command = "CREATE TABLE StudentAnswers(
            StudentID int FOREIGN KEY REFERENCES Students(StudentID) ON DELETE CASCADE,
            QuestionNumber int,
            PartID int, 
            StudentAnswer varchar(250),
            MarkAwarded int, 
            CONSTRAINT StudentAnswersPK PRIMARY KEY (StudentID, QuestionNumber, PartID),
            ); "
        NonQueryCommand(command)
    End Sub

    Public Sub createTableStudentUsers()
        ' STUDENT USERS
        Dim command As String
        command = "CREATE TABLE StudentUsers(
            UserID int IDENTITY(1,1) PRIMARY KEY,
            Username varchar(40) NOT NULL,
            Password varchar(40) NOT NULL,
            ); "
        NonQueryCommand(command)
    End Sub

    Public Sub createTableStudentReports()
        ' STUDENT REPORTS
        Dim command As String
        command = "CREATE TABLE StudentReports(
            ReportID varchar(50) FOREIGN KEY REFERENCES Reports(ReportID) ON DELETE CASCADE,
            Name varchar(60),
            UserID int FOREIGN KEY REFERENCES StudentUsers(UserID) ON DELETE CASCADE,
            CONSTRAINT StudentReportsPK PRIMARY KEY (Name, ReportID)
            ); "
        NonQueryCommand(command)
    End Sub


#End Region

#Region "Commands"
    ''' <summary>
    ''' Insert values into table
    ''' </summary>
    ''' <param name="tableAttrString">String format = "table_name (column1_name, column2_name, column3_name...)</param>
    ''' <param name="values">Array of strings containing field values </param>
    Public Sub AddValues(tableAttrString As String, values As String())
        'specify table and columns
        Dim command As String = $"INSERT INTO {tableAttrString} VALUES ("

        'specify values
        For i = 0 To values.Count - 2
            command &= $"'{values(i)}', "
        Next
        command &= $"'{values(values.Count - 1)}')"

        'execute
        NonQueryCommand(command)
    End Sub

    ''' <summary>
    ''' Update values in table
    ''' </summary>
    ''' <param name="table">Table name as string</param>
    ''' <param name="newValues">2d array with a row for each column to be updated. Row format: {column_name, new_value} </param>
    ''' <param name="condition">Any valid SQL condition e.g. "columns = value OR column2 = value2"</param>
    Public Sub UpdateValues(table As String, newValues As String(,), Optional condition As String = "")
        'specify table
        Dim command As String = $"UPDATE {table} SET "

        'specify columns and values
        For i = 0 To newValues.GetLength(0) - 2
            command &= $"{newValues(i, 0)} = '{newValues(i, 1)}', "
        Next
        command &= $"{newValues(newValues.GetLength(0) - 1, 0)} = '{newValues(newValues.GetLength(0) - 1, 1)}' "


        'specify condition
        If condition <> "" Then
            condition = " WHERE " & condition
        End If
        command &= condition

        ' execute
        NonQueryCommand(command)
    End Sub

    ''' <summary>
    ''' Delete values from table
    ''' </summary>
    ''' <param name="table">Table name as string</param>
    ''' <param name="condition">Any valid SQL condition e.g. "columns = value OR column2 = value2</param>
    Public Sub DeleteValues(table As String, Optional condition As String = "")
        'specify table
        Dim command As String = $"DELETE FROM {table}"

        'specify condition
        If condition <> "" Then
            command &= " WHERE " & condition
        End If
        ' execute
        NonQueryCommand(command)
    End Sub

    ''' <summary>
    ''' Select values from table
    ''' </summary>
    ''' <param name="table">Table name as string</param>
    ''' <param name="columns">String format: "column1_name, column2_name, ... columnX_name" or "*"</param>
    ''' <param name="condition">Any valid SQL condition e.g. "columns = value OR column2 = value2</param>
    ''' <returns></returns>
    Public Function SelectValues(table As String, columns As String, Optional condition As String = "", Optional join As Boolean = False) As List(Of Object())
        'specify table and columns
        Dim command As String = $"SELECT {columns} FROM {table}"

        'specify condition
        If condition <> "" Then
            If Not join Then
                command &= " WHERE " & condition
            Else ' join
                command &= " " & condition

            End If
        End If

        ' execute
        Return QueryCommand(command)
    End Function

#End Region


End Class

