// Lesson 8 Activity - Exam Centre
// Pseudo_Code
// 1. Create Student Class: Student Number (public), Student Name (private), Score (public)
// 2. Create Exam Class: Subject (public), Student List (public)
// 3. Put classes in their own files, and put classes in a Models folder - check namespaces of classes (eg: Lesson 8 Activity.Models)
// 4. In Main method, create a new exam and set the subject, eg: var exam = new Exam("Bioinformatics"); 
// Create some students and add some scores for their exam. You should be able to set the student’s names when you create them, 
// but you should not be able to directly access the student’s name after that.
// So you might be able to run commands such as
// var student1 = new Student(“Ama”, 3314);
// var student2 = new Student(“Jess”, 3315);
// exam.AddStudent(student1);
// exam.AddStudent(student2);
// to add a new student named Ama with candidate 3314 CW23492.

// 5. You should come up with a way for examiners to add results to the student papers, so that to give the paper of student with candidate number 
// 3315 a score of 55, you can run a command such as exam.MarkPaper(3315, 55);
using ExamCentre.Models;
namespace ExamCentre
{
    static List<Student> CreateStudents()
    {
        var student1 = new Student();
        student1.name = "Ama";
        student1.studentNumber = 3314;
        student1.score = 60;
        student1.exam = "Chemistry";

        var student2 = new Student();
        student2.name = "Jess";
        student2.studentNumber = 3315;
        student2.score = 40;
        student2.exam = "Maths";

    }
    static List<Exam> CreateExams()
    {        
        var exam1 = new Exam ();
        exam1.examName = "Chemistry";
        
        var exam2 = new Exam ();
        exam2.examName = "Maths";

        var exams = new List<Exam> 
        {
            exam1, exam2,
        };

        return exams;
    }
}