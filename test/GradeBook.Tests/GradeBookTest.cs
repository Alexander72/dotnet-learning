 ..using System;
using Xunit;

namespace GradeBook.Tests
{
    public class GradeBookTest
    {
        [Fact]
        public void TestStatistic()
        {
            GradeBook gradeBook = new GradeBook();
            gradeBook.addGrade(14.5);
            gradeBook.addGrade(53.5);
            gradeBook.addGrade(36.1);

            Statistic statistic = gradeBook.generateStatistic();

            Assert.Equal(14.5, statistic.lowestGrade);
            Assert.Equal(53.5, statistic.highestGrade);
            Assert.Equal(34.7, statistic.averageGrade, 1);
            Assert.Equal(3, statistic.gradesCount);
        }
    }
}
