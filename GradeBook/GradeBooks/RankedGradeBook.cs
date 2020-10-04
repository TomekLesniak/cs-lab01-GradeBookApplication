using System;
using System.Collections.Generic;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            this.Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationException();

            int grade = 1; // F
            int studentsMakeTwentyPercentage = Students.Count / 5;

            int count = 1;
            foreach (var student in Students)
            {
                if (student.AverageGrade < averageGrade)
                    count++;
            }

            grade = count / studentsMakeTwentyPercentage;

            if (grade == 5)
                return 'A';
            if (grade == 4)
                return 'B';
            if (grade == 3)
                return 'C';
            if (grade == 2)
                return 'D';

            return 'F';
        }

        public override void CalculateStatistics()
        {
            if(Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else
                base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else
                base.CalculateStudentStatistics(name);
            
        }
    }
}