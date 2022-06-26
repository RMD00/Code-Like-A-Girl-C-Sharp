namespace ExamCentre.Models 
{
    public class Student
    {
        public int StudentNumber { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public Student (string name, int studentNumber, int score)
        {   
            StudentNumber = studentNumber;
            Name = name; 
            Score = score;
        }
    }
}