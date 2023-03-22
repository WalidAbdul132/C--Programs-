using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Question12
{
    class Student
    {
        public string StudentId { get; set; }
        public string Name { get; set; }
        public decimal MarksInEnglish { get; set; }
        public decimal MarksInScience { get; set; }
        public decimal MarksInSocialScience { get; set; }
        public decimal MarksInMathematics { get; set; }
        public decimal MarksInComputerScience { get; set; }
        public decimal TotalMarks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty student list
            var students = new Student[10];

            // Prompt the user to enter the student list
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Enter the details of student #" + (i + 1));

                // Student id
                Console.Write("Student id: ");
                string studentId = Console.ReadLine();
                while (!Regex.IsMatch(studentId, @"^\d+$"))
                {
                    Console.WriteLine("Error: Student id must not be blank and must contain only numbers.");
                    Console.Write("Student id: ");
                    studentId = Console.ReadLine();
                }

                // Name
                Console.Write("Name: ");
                string name = Console.ReadLine();

                // Marks in English
                Console.Write("Marks in English: ");
                string marksInEnglishString = Console.ReadLine();
                while (!Regex.IsMatch(marksInEnglishString, @"^\d+(\.\d{1,2})?$"))
                {
                    Console.WriteLine("Error: Marks must contain two decimal points only.");
                    Console.Write("Marks in English: ");
                    marksInEnglishString = Console.ReadLine();
                }
                decimal marksInEnglish = decimal.Parse(marksInEnglishString);

                // Marks in Science
                Console.Write("Marks in Science: ");
                string marksInScienceString = Console.ReadLine();
                while (!Regex.IsMatch(marksInScienceString, @"^\d+(\.\d{1,2})?$"))
                {
                    Console.WriteLine("Error: Marks must contain two decimal points only.");
                    Console.Write("Marks in Science: ");
                    marksInScienceString = Console.ReadLine();
                }
                decimal marksInScience = decimal.Parse(marksInScienceString);

                // Marks in Social Science
                Console.Write("Marks in Social Science: ");
                string marksInSocialScienceString = Console.ReadLine();
                while (!Regex.IsMatch(marksInSocialScienceString, @"^\d+(\.\d{1,2})?$"))
                {
                    Console.WriteLine("Error: Marks must contain two decimal points only.");
                    Console.Write("Marks in Social Science: ");
                    marksInSocialScienceString = Console.ReadLine();
                }
                decimal marksInSocialScience = decimal.Parse(marksInSocialScienceString);

                // Marks in Mathematics
                Console.Write("Marks in Mathematics: ");
                string marksInMathematicsString = Console.ReadLine();
                while (!Regex.IsMatch(marksInMathematicsString, @"^\d+(\.\d{1,2})?$"))
                {
                    Console.WriteLine("Error: Marks must contain two decimal points only.");
                    Console.Write("Marks in Mathematics: ");
                    marksInMathematicsString = Console.ReadLine();
                }
                decimal marksInMathematics = decimal.Parse(marksInMathematicsString);

                // Marks in Computer Science
                Console.Write("Marks in Computer Science: ");
                string marksInComputerScienceString = Console.ReadLine();
                while (!Regex.IsMatch(marksInComputerScienceString, @"^\d+(\.\d{1,2})?$"))
                {
                    Console.WriteLine("Error: Marks must contain two decimal points only.");
                    Console.Write("Marks in Computer Science: ");
                    marksInComputerScienceString = Console.ReadLine();
                }
                decimal marksInComputerScience = decimal.Parse(marksInComputerScienceString);

                // Calculate total marks
                decimal totalMarks = marksInEnglish + marksInScience + marksInSocialScience + marksInMathematics + marksInComputerScience;

                // Create a new student object with the entered data
                var student = new Student
                {
                    StudentId = studentId,
                    Name = name,
                    MarksInEnglish = marksInEnglish,
                    MarksInScience = marksInScience,
                    MarksInSocialScience = marksInSocialScience,
                    MarksInMathematics = marksInMathematics,
                    MarksInComputerScience = marksInComputerScience,
                    TotalMarks = totalMarks
                };

                // Add the student to the student list
                students[i] = student;
            }

            // Print the student list
            foreach (var student in students)
            {
                Console.WriteLine("Student id: " + student.StudentId);
                Console.WriteLine("Name: " + student.Name);
                Console.WriteLine("Marks in English: " + student.MarksInEnglish);
                Console.WriteLine("Marks in Science: " + student.MarksInScience);
                Console.WriteLine("Marks in Social Science: " + student.MarksInSocialScience);
                Console.WriteLine("Marks in Mathematics: " + student.MarksInMathematics);
                Console.WriteLine("Marks in Computer Science: " + student.MarksInComputerScience);
                Console.WriteLine("Total Marks: " + student.TotalMarks);
            }

            Console.ReadLine();
        }
    }
}






