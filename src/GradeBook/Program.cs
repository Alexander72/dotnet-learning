using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook gradeBook = new GradeBook();
            gradeBook.addGrade(24.6);
            gradeBook.addGrade(73.4);
            gradeBook.addGrade(19.5);

            Statistic statistic = gradeBook.generateStatistic();

            Console.WriteLine($"Highest grade is {statistic.highestGrade}");
        }
    }
}
