// Create list of students
var students = new List<string>{"Joy", "Marta", "Yuko", "Anjen"};
// Create list of courses at the university
var courses = new List<string>{"Chemistry", "Fashion Design", "Philosophy", "Medicine"};
var chemistryStudents = new List<string>{};


while (true)
	{
		Console.WriteLine("What would you like to see or do?");
		// list what options the user can enter
		Console.WriteLine("Students = See a list of students at the university");
		Console.WriteLine("Courses = See a list of courses at the university");
        Console.WriteLine("StudentsCourses = See which courses each sudent is enrolled in");
		Console.WriteLine("Enrol = Enrol a new student at the university");
        Console.WriteLine("AddStudentToCourse = Add an enrolled student to a particular course");
		Console.WriteLine("Unenrol = Unenrol a student");
		Console.WriteLine("AddCourse = Add a new course to the university catalogue");
		Console.WriteLine("RemoveCourse = Remove a course from the university catalogue");
        Console.WriteLine("CourseEnrolment = List of students enrolled in a course");
        Console.WriteLine("X = Exit");
		var userInput = Console.ReadLine();
		// exit the code if a user inputs X

            if (userInput == "X")
				{
					break;
				}

        // respond to the user command
	        switch (userInput)
		        {
			    case "Students":
			    Console.WriteLine("Here is a list of students:");
			        // code to list all students
                    foreach(var student in students)
                        {
                            Console.WriteLine(student);
                        }
        			    break;

			    case "Courses":
			        Console.WriteLine("Here is a list of courses offered:");
			        // code to list all courses
                    foreach(var course in courses)
                        {
                            Console.WriteLine(course);
                        }
			            break;

                case "AddStudentToCourse":
                    Console.WriteLine("What is the name of the student you would like to add to a course?");
                    var nameStudent = Console.ReadLine();
                    Console.WriteLine($"What is the name of the course you would like to enrol {nameStudent} in?");
                    var courseChosen = Console.ReadLine();
                        if (courseChosen == "Chemistry")
                            {
                                chemistryStudents.Add(nameStudent);
                            }
                        break;

                case "StudentsCourses":
                    Console.WriteLine("Which student would you like to see the courses they are enrolled in?");
                    var whichStudent = Console.ReadLine();
                    Console.WriteLine($"{whichStudent} is enrolled in {XX}");


                    break;

                case "CourseEnrolment":
                    Console.WriteLine("For which course would you like to see the enrolment list?");
                    var whichCourse = Console.ReadLine();
                    Console.WriteLine($"The following students are enrolled in {whichCourse}");
                    foreach(var chemistryStudent in chemistryStudents)
                        {
                            Console.WriteLine(chemistryStudent);
                        }
        			    break;
                                   
                case "Enrol":
	    		    Console.WriteLine("What is the students name:");
    			    // code to enrol a student
                    string name;
                    name = Console.ReadLine();
                    students.Add(name);
                    Console.WriteLine($"{name} has been added to the list of students enrolled.");
                    break;

                case "Unenrol":
		    	    Console.WriteLine("What is the students name:");
			        // code to unenrol a student
                    string removeName;
                    removeName = Console.ReadLine();
                    students.Remove(removeName);
                    Console.WriteLine($"{removeName} has been removed from the list of students enrolled.");
                    break;

                case "AddCourse":
			        Console.WriteLine("What is the new course name:");
			        // code to add a new course
                    string newCourse;
                    newCourse = Console.ReadLine();
                    courses.Add(newCourse);
                    Console.WriteLine($"{newCourse} has been added to the list of courses offered.");
                    break;

                case "RemoveCourse":
			        Console.WriteLine("What is the name of the course you would like to remove:");
			        // code to remove a course
                    string removeCourse;
                    removeCourse = Console.ReadLine();
                    courses.Remove(removeCourse);
                    Console.WriteLine($"{removeCourse} has been removed from the list of courses offered.");
                    break;

			    default:
			    Console.WriteLine("I didn't recognise that command");
			    break;
                }
    }