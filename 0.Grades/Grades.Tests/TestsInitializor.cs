using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    public class TestsInitializor
    {
        public GradeStatistics Setup(List<float> grades)
        {
            var gradeBook = new GradeBook();

            foreach (var grade in grades)
            {
                gradeBook.AddGrade(grade);
            }

            var statistics = gradeBook.CalculateStatistics();

            return statistics;
        }
    }
}
