using System;

namespace _04._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int theNumberOfStudents = int.Parse(Console.ReadLine());
            double theExamGrade = double.Parse(Console.ReadLine());
            double sum = 0;
               
            double percentageOfStudents = sum / theNumberOfStudents * 100;

            if (theExamGrade >= 5.00)
            {
                Console.WriteLine($"Top students: {percentageOfStudents}%");
            }
            else if (theExamGrade >= 4.00 && theExamGrade <= 4.99)
            {
                Console.WriteLine($"Between 4.00 and 4.99: {percentageOfStudents}%");
            }
            else if (theExamGrade >= 3.00 && theExamGrade <= 3.99)
            {
                Console.WriteLine($"Between 3.00 and 3.99:  {percentageOfStudents}%");
            }
            else if (theExamGrade <= 3.00)
            {
                Console.WriteLine($"Fail: {percentageOfStudents}%");
            }
            double average = theExamGrade / theNumberOfStudents;
            Console.WriteLine($ "Average: {average:f2}");
        }
    }
}
