﻿using System;
using System.Collections.Generic;

namespace gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook gradeBook = new GradeBook();
            gradeBook.addGrade(24.6);
            gradeBook.addGrade(73.4);
            gradeBook.addGrade(19.5);

            Console.WriteLine($"Highest grade is {gradeBook.getHighest()}");
        }
    }
}
