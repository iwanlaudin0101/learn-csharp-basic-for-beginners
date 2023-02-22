using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqBasicBeginner.Data;
using LinqBasicBeginner.ModelDtos;
using LinqBasicBeginner.Models;

namespace LinqBasicBeginner
{
    public class StudentService
    {
        private readonly Datas _data;
        public StudentService()
        {
            _data = new Datas();
        }

        public List<StudentGroupMaxDto> QueryGroupMax()
        {
            var result = (from student in _data.students
                group student by student.Year into studentGroup
                select new StudentGroupMaxDto
                {
                    Level = studentGroup.Key,
                    HighestScore = (
                        from student2 in studentGroup
                        select student2.ExamScores?.Average()
                    ).Max()
                }).ToList();

            return result;
        }

        public List<QueryHighScoreDto> queryHighScores(int exam, int score) 
        {
            var result = (from student in _data.students
                where student.ExamScores?[exam] > score
                orderby student.ExamScores?[exam] descending
                select new QueryHighScoreDto
                {
                    StudentId = student.ID,
                    Name = $"{student.FirstName} {student.LastName}",
                    Year = student.Year,
                    Score = student.ExamScores?[exam]
                }).ToList();
            
            return result;
        }
    }
}