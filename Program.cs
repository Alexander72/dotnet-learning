using System;
using System.Collections.Generic;

namespace gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();
            grades.Add(34.3);
            grades.Add(12.6);
            grades.Add(34.9);

            double sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            }

            double average = sum / grades.Count;
            Console.WriteLine($"Grades sum is {sum}");
            Console.WriteLine($"Grades avg is {average:N3}");
        }
    }
}
