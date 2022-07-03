using System;
namespace ExamCentre.Models 
{
    public class Exam
    {
        public string Subject { get; set; }
        public Exam(string subject)
        {
            Subject = subject;
        }

        public Exam(){} // empty contructor

        public void ListOfStudents()
        {
            foreach (var Student in students)
            {
                Student.PrintStudentList();
            }
        }     

    }
}
