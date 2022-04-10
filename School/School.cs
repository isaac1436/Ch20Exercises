using School;

namespace School
{
    public class School
    {
        static void Main()
        {
            bool ErrorCatch = false;
            string[,] classes;
            Courses[] courses;
            string[,] studDetails;
            Classes.Students[] students;
            int subjectNo = 0, studCount = 0;
            Console.WriteLine("Welcome to our school Teacher-Class Registration Program (TCRP)");

            Console.Write("\n\nPlease enter the Teacher's name: ");
            string name = Console.ReadLine();

            Console.Write("\nPlease enter the name of the class taught by the teacher: ");
            string classID = Console.ReadLine();

           Teachers teacher = new Teachers(name);

            Console.Write("\n\nHow many subjects are the students offering: ");
            ErrorCatch = int.TryParse(Console.ReadLine(), out subjectNo);
            classes = new string[subjectNo, 3];
            courses = new Courses[subjectNo];

            for (int i = 0; i < subjectNo; i++)
            {
                Console.Write("\nPlease enter the course Name: ");
                classes[i, 0] = Console.ReadLine();

                Console.Write("\nPlease enter the number of classes(in digits): ");
                classes[i, 1] = Console.ReadLine();

                Console.Write("\nPlease enter the number of Exercises to be performed(in digits): ");
                classes[i, 2] = Console.ReadLine();

                courses[i] = new Courses(classes[i, 0], int.Parse(classes[i, 1]), int.Parse(classes[i, 2]));
                Console.WriteLine("\n");
            }

            Console.Write("\n\nHow many students are in this class: ");
            ErrorCatch = int.TryParse(Console.ReadLine(), out studCount);
            studDetails = new string[studCount, 2];
            students = new Classes.Students[studCount];

            for (int i = 0; i < studCount; i++)
            {
                Console.Write("\nPlease enter the students name: ");
                studDetails[i, 0] = Console.ReadLine();
                Console.Write("\nPlease enter the students ID no: ");
                studDetails[i, 1] = Console.ReadLine();

                students[i] = new Classes.Students(studDetails[i, 0], studDetails[i, 1]);

                Console.WriteLine("\n");
            }

            Console.WriteLine("\t\t\t{0}-{1}", teacher.name, classID);

            Console.WriteLine("\n\nS/N \t\tStudent's Name\t\tStudent's RegNo");

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("\n{0}. \t\t{1} \t\t{2}", i + 1, students[i].name, students[i].studentCode);
            }

            Console.WriteLine("\n\n\nS/N \tCourse Title\t\tNo Of Classes\tNo of Exercises");

            for (int i = 0; i < courses.Length; i++)
            {
                Console.Write("\n{0}. \t{1}\t\t\t{2}\t\t{3}", i + 1, courses[i].courseName, courses[i].noOfClasses, courses[i].exerciseCount);
            }


        }
    }
}