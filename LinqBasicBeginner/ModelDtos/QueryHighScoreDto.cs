using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqBasicBeginner.Models;

namespace LinqBasicBeginner.ModelDtos
{
    public class QueryHighScoreDto
    {
        public int StudentId { get; set; }
        public string Name { get; set; } = string.Empty;
        public GradeLevel? Year { get; set; }
        public int? Score { get; set; }
    }
}