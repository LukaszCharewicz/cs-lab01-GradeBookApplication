using System;
using System.Collections.Generic;
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

        //public override char GetLetterGrade()
        //{
        //    var test = 0;

        //    if (test == 0)
        //        return 'A';
        //    else if (test == 1)
        //        return 'B';
        //    else if (test == 2)
        //        return 'C';
        //    else if (test == 3)
        //        return 'D';
        //    else if (test == 4)
        //        return 'E';
        //}

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
