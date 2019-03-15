using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSpeechSynthesisEnabled = false;
            SpeechSynthesis speechSynthesis = new SpeechSynthesis();
            if (isSpeechSynthesisEnabled)
            {
                speechSynthesis.Speek();
            }

            GradeBook gradeBook = new GradeBook();


            Console.WriteLine("Enter grade1:");
            float grade2 = float.Parse(Console.ReadLine());
            gradeBook.AddGrade(grade2);

            Console.WriteLine("Enter grade2:");
            float grade1 = float.Parse(Console.ReadLine());
            gradeBook.AddGrade(grade1);

            Console.WriteLine("Enter grade3:");
            float grade3 = float.Parse(Console.ReadLine());
            gradeBook.AddGrade(grade3);



            var statistics = gradeBook.CalculateStatistics();
            if(statistics.HasStatistics)
            {
                Console.WriteLine("statistics.Average: " + statistics.Average);
                Console.WriteLine("statistics.High: " + statistics.High);
                Console.WriteLine("statistics.Low: " + statistics.Low);
                Console.WriteLine("statistics.Total: " + statistics.Total);
            }

            Console.WriteLine("hit any key to exit ...");
            Console.ReadLine();
        }
    }
}
