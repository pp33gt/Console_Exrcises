using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public List<float> Grades;

        public GradeBook()
        {
            Grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            Grades.Add(grade);
        }

        public GradeStatistics CalculateStatistics()
        {
            var result = new GradeStatistics();
            
            for (int i = 0; i <= Grades.Count - 1; i++)
            {
                var grade = Grades[i];

                result.Total += grade;

                result.High = i == 0 ? grade : Math.Max(grade, result.High);

                result.Low = i == 0 ? grade : Math.Min(grade, result.Low);

                result.HasStatistics = true;
            }

            if (result.HasStatistics)
            {
                result.Average = result.Total / Grades.Count;
            }

            return result;
        }

    }
}
