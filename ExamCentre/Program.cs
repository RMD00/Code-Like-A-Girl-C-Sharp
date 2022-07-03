﻿using ExamCentre.Models;

namespace ExamCentre
{
    class Program
    { 
        static void Main()
        {   
            var subject = new Exam("Bioinformatics");
            
            var student1 = new Student();
            student1.Name = "Ama";
            student1.StudentNumber = 3314;
            student1.Score = 70;
            Student.AddStudent(student1);
            
            var student2 = new Student();
            student2.Name = "Ama";
            student2.StudentNumber = 3315;
            student2.Score = 40;
            Student.AddStudent(student2);
          
            Student.PrintStudentList;
          
       
            
            // Console.WriteLine("Welcome to the Exam Centre. What would you like to do:");
            // Console.WriteLine("1 - List students in the exam (by student number)");
            // Console.WriteLine("2 - Add student score");
            // var choice = Console.ReadLine();

            // switch(choice)
            // {
            // case "1":
            //     // List students in the exam
            //     foreach (var student in Students); 
            //         {
            //         Console.WriteLine($"Student {studentNumber} is taking the {subject} exam");
            //         }
            //     break;
         
            // case "2": 
            //     // Add student score
            //     Console.WriteLine("What is the name of the student you would like to add?");
            //     var newName = Console.ReadLine();
            //     Console.WriteLine("What is the student number of the student you would like to add?");
            //     var newStudentNumber = Console.ReadLine();
            //     Console.WriteLine("What is the student's score?");
            //     var newScore = Console.ReadLine();
 
            //     Exam.MarkPaper(); 
            //     break;
        }
    }
}









   