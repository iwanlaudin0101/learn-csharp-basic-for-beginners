using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqBasicBeginner.Models;

namespace LinqBasicBeginner.ModelDtos
{
    public class StudentGroupMaxDto
    {
        public GradeLevel? Level { get; set; }
        public double? HighestScore { get; set; }
    }
}