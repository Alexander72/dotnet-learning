using System;
using System.Collections.Generic;

namespace GradeBook
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

        public Statistic generateStatistic()
        {
            Statistic statistic = new Statistic();
            foreach(double grade in this.grades)
            {
                statistic.highestGrade = Math.Max(grade, statistic.highestGrade);
                statistic.lowestGrade = Math.Min(grade, statistic.lowestGrade);
                statistic.averageGrade += grade;
            }

            statistic.averageGrade /= this.grades.Count;
            statistic.gradesCount = this.grades.Count;

            return statistic;
        }
    }
}