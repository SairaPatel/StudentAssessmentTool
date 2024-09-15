# Student Assessment Tool
 
## Background
This project was my for my Computer Science A-level (2021-2023) and I was awarded the full marks.
The requirements were to come up with our own idea for an application and go through the analysis, design, implementation, testing and evaluation process over the course of a year. 
I chose to do a desktop application in Visual basic that allows teachers within a school to create and share tests/quizzes that could be completed live by their students. 

## Overview
Here is a snippet from my project report introduction:

When first thinking about project ideas, I wanted to create something involving the creation of a client-server network. Since I am in a school setting, a classroom tool was an obvious option. I know that a significant aspect of a teacher’s workload involves assessing students’ progress and abilities. This can often be difficult to do manually for large classes without being time consuming and repetitive. This is how I arrived at the idea of a Student Assessment Tool for teachers in a school.

My initial idea was based off of a website called Kahoot which allows users to host a live Quiz for players to connect to over the internet. However, as shown in this image, the complexity of Kahoot’s quizzes does not exceed multiple-choice questions. For GCSE and A-level students, assessments must consist of questions that test full fact recollection and in-depth understanding of concepts. Therefore, whilst Kahoot only allows the use of multiple-choice questions in a quiz, this program should allow the creation of more complex questions that allow more input and thinking from the students.

A key element of the final program will be the review of ‘student performance’ for the teacher. As well as allow students to answer questions, it is important that the program can organise the results in a way that will be helpful to the teacher. Teachers may need to analyse the performance of individual students as well as their class overall. This is why the program should produce a comprehensive report at the end of each assessment. 

Since the target end-user for my program would be teachers and students in a school, the connection for the game could run over the school’s internal network. In order for the program to be convenient for teachers, the user should be able to save any assessments that they create, and possibly access some from other teachers in their school. For this reason, I decided to save all users’ assessments to a database stored on a drive that is shared and accessible to any computer in the network.


## Design Diagrams

### DFD 
![image](https://github.com/user-attachments/assets/73cdaecd-d482-4573-b054-3b14717dd415)
![image](https://github.com/user-attachments/assets/59e20e24-a0ee-4e08-9290-05f8c59cae11)

### Database Design
![image](https://github.com/user-attachments/assets/370366da-76ae-42b7-89f7-6ca6b86a8031)



## The Application
On opening the application, the user will be able to select either Teacher or Student. 

### Student

Students will be able to enter a Live Assessment PIN which, if valid, will take them to the assessment Lobby where they may have the ability to change their name.
Dependant on the teacher’s settings, the student may be able to start the assessment themselves or may have to wait for their student to start the assessment for the whole class.
  
<img src="https://github.com/user-attachments/assets/49e2bbbf-824e-4d9a-b008-0ec91f398e0b" width="570"/>

Once started, the student will be able to answer each question as it appears on their screen. For an assessment in Test Mode, they will be able to navigate between questions themselves.
In Game mode they will answer each question as it appears on their screen, with the teacher in control of the navigation.
 
<img src="https://github.com/user-attachments/assets/496e8600-d31c-46a3-a918-7528b35a0538" width="570"/>

Depending on the teacher’s settings, the student may be able to view their marks after each question or after the entire assessment.
Student's can also register/log in to view their reports from quizes/assessments that they have done.

<img src="https://github.com/user-attachments/assets/dd367afe-1dbb-4779-bf2e-d5affea7a1df" width="570"/>

### Teacher

Teachers will first be required to create an account or login.

<img src="https://github.com/user-attachments/assets/2b0677ab-90e6-4744-8418-479db4c03fd6" width="570"/>

Once signed in they will be able to access their own assessments as well as create new ones.
They are also able to select other Teacher users that they wish to share each assessment with and are able to view assessments that have been shared with them by others.

<img src="https://github.com/user-attachments/assets/5efbe071-cc2e-4a66-8e00-2c74290f330f" width="370"/>
<img src="https://github.com/user-attachments/assets/cce0c21c-f5f9-476f-b5ff-7ff34dcdca1c" width="370"/>


They can create questions in their assessments, each with up to 4 parts.

<img src="https://github.com/user-attachments/assets/a87ef43c-76a6-44b3-aefe-8d224f991f2d" width="370"/>
<img src="https://github.com/user-attachments/assets/33becab5-1cc7-47c0-ae28-76575eca4232" width="370"/>
 
Teachers can start a live assessment in either Game mode or Test mode.
They will be taken to a lobby where they can view as students join.
If in Game mode, the teacher can start the assessment otherwise they would wait for each student to start individually.

<img src="https://github.com/user-attachments/assets/7400aff0-59c2-4a50-9eeb-02cd2ba09bf9" width="370"/>
<img src="https://github.com/user-attachments/assets/11ebc9ea-dcaa-4960-b323-6e4ec3154a1a" width="370"/>


The teacher has access to each student’s marks for the assessment and these will be saved, along with an analysis of these marks, as Live Reports which they can view later in their account.

<img src="https://github.com/user-attachments/assets/34c9e704-ef1d-40fb-b897-8b486068357e" width="570"/>


## Preview

### Teacher


### Demo/Testing Video
To view a demo of this application, you can watch the [testing videos here](https://www.youtube.com/playlist?list=PLyM6MY7dgsClciIDk9YyttyGTbSItXfeo).


## Future Development
Possible additional features to implement:
- Add images to questions
- Show correct answer to question on both student's and teacher's screen (not just teacher's)
- Allow teacher's to organise assessments/reports into folders (requires additional DB relations)
- Add some level of auto-marking to long-text questions (e.g. allow input of keywords that would gain marks) 
