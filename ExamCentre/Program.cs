namespace ExamCentre.Models
{
    class Program
    { 
        public static void Main()
        {   
            var subject = new Exam("Bioinformatics");
            var student1 = new Student("Ama", 3314, 72);
            var student2 = new Student("Jess", 3315, 40);
            Exam.AddStudent(student1);
            Exam.AddStudent(student2);            
            
            Console.WriteLine("Welcome to the Exam Centre. What would you like to do:");
            Console.WriteLine("1 - List students in the exam (by student number)");
            Console.WriteLine("2 - Add student score");
            var choice = Console.ReadLine();

            switch(choice)
            {
            case "1":
                // List students in the exam
                foreach (var student in Students); 
                    {
                    Console.WriteLine($"Student {studentNumber} is taking the {subject} exam");
                    }
                break;
         
            case "2": 
                // Add student score
                Console.WriteLine("What is the name of the student you would like to add?");
                var newName = Console.ReadLine();
                Console.WriteLine("What is the student number of the student you would like to add?");
                var newStudentNumber = Console.ReadLine();
                Console.WriteLine("What is the student's score?");
                var newScore = Console.ReadLine();

                Exam.MarkPaper(); 
                break;
            }
        }
    }
}








   