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

        public List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);    
        }

        public void MarkPaper(int studentNumber, int score)
        {
            var student = students.Find(x => x.StudentNumber == studentNumber);
            student.AddScore(score);
            
        }
    }
}
