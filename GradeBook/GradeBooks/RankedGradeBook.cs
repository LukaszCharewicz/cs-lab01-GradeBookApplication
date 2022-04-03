using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {

        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationException("Ranked grading requires at least 5 students");
            else
            {
                var numberOfStudents = Students.Count;
                var x = (int)Math.Ceiling(numberOfStudents * 0.2);
                var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();

                if (grades[x - 1] <= averageGrade)
                    return 'A';
                else if (grades[(x * 2) - 1] <= averageGrade)
                    return 'B';
                else if (grades[(x * 3) - 1] <= averageGrade)
                    return 'C';
                else if (grades[(x * 4) - 1] <= averageGrade)
                    return 'D';
                else
                    return 'F';
            }
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students");
            }
            else
            {
                base.CalculateStatistics();
            }
        }

    }
}
