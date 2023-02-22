using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqBasicBeginner.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public GradeLevel? Year { get; set; }
        public List<int>? ExamScores { get; set; }
    }

    public enum GradeLevel
    {
        FirstYear = 1,
        SecondYear,
        ThirdYear,
        FourthYear
    };
}