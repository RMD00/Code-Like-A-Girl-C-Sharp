using ExamCentre.Models;
namespace ExamCentre
{
    class Program
    { 
        public static void Main(){

Console.WriteLine("Welcome to the Exam Centre. What would you like to do:");
Console.WriteLine("1 - Add a new exam subject");
Console.WriteLine("2 - Add a new student");
Console.WriteLine("3 - Add a student's score");
var choice = Console.ReadLine();

    switch(choice)
    {
        case "1":
            // code to execute
            var exam = new Exam(); 
            Console.WriteLine("What is the subject of the exam you would like to add?");
            var subject = Console.ReadLine();
            exam.AddExam(); // you need to create an add.exam function
            break;
         case "2":
            // code to execute
            var student3 = new Student();
            Console.WriteLine("What is the name of the student you would like to add?");
            var studentName = Console.ReadLine();
            student.AddStudent(); // add.student function
            break;
         case "3":
            // code to execute
            break;
    }
        }
    static List<Student> CreateStudents()
    {
        var student1 = new Student
        {
        name = "Ama",
        studentNumber = 3314,
        score = 60,
        subject = "Chemistry",
        };

        var student2 = new Student();
        student2.name = "Jess";
        student2.studentNumber = 3315;
        student2.score = 40;
        student2.subject = "Maths";

        var students = new List<Student> 
        {
            student1, student2,
        };

        return students;

    }
    static List<Exam> CreateExams()
    {        
        var exam1 = new Exam
        {
        subject = "Chemistry",
        };
        
        var exam2 = new Exam ();
        exam2.subject = "Maths";

        var exams = new List<Exam> 
        {
            exam1, exam2,
        };

        return exams;
    }
    
    }
}








   