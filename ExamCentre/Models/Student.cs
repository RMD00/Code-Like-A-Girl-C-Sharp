using System;
namespace ExamCentre.Models 
{
    public class Student
    {
        public int StudentNumber { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public Student(int studentNumber, string name, int score)
        {
            StudentNumber = studentNumber;
            Name = name; 
            Score = score;
        }

        public Student(){} // Empty constructor

        public void AddStudent(Student student)
        {
            students.Add(student);    
        }

        public void PrintStudentList()
        {
            Console.WriteLine($"Student number: {StudentNumber} scored {Score}.");
        }

    }
}