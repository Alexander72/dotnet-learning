using System;
using System.Collections.Generic;

namespace gradebook
{
    public class GradeBook
    {
        List<double> grades;

        public GradeBook()
        {
            this.grades = new List<double>();
        }

        public void addGrade(double grade)
        {
            grades.Add(grade);
        }

        public double getHighest()
        {
            double result = double.MinValue;
            foreach(double grade in this.grades)
            {
                result = Math.Max(grade, result);
            }

            return result;
        }
    }
}