using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqBasicBeginner.Models;

namespace LinqBasicBeginner.Data
{
    public class Datas
    {
        public List<Student> students = new List<Student>
        {
            new Student 
            {
                ID = 1,
                FirstName = "Terry", 
                LastName = "Adams",
                Year =  GradeLevel.SecondYear,
                ExamScores = new() { 99, 82, 81, 79 }
            },
            new Student {
                ID = 2,
                FirstName = "Fadi", 
                LastName = "Fakhouri",
                Year = GradeLevel.ThirdYear,
                ExamScores = new() { 99, 86, 90, 94 }
            },
            new Student {
                ID = 3,
                FirstName = "Hanying", 
                LastName = "Feng",
                Year = GradeLevel.FirstYear,
                ExamScores = new() { 93, 92, 80, 87 }
            },
            new Student {
                ID = 4,
                FirstName = "Cesar", 
                LastName = "Garcia",
                Year = GradeLevel.FourthYear,
                ExamScores = new() { 97, 89, 85, 82 }
            },
            new Student {
                ID = 5,
                FirstName = "Debra", 
                LastName = "Garcia", 
                Year = GradeLevel.ThirdYear,
                ExamScores = new() { 35, 72, 91, 70 }
            },
            new Student {
                ID = 6,
                FirstName = "Hugo",
                LastName = "Garcia",
                Year = GradeLevel.SecondYear,
                ExamScores = new() { 92, 90, 83, 78 }
            },
            new Student {
                ID = 7,
                FirstName = "Sven",
                LastName = "Mortensen",
                Year = GradeLevel.FirstYear,
                ExamScores = new() { 88, 94, 65, 91 }
            },
            new Student {
                ID = 8,
                FirstName = "Claire", 
                LastName = "O'Donnell", 
                Year = GradeLevel.FourthYear,
                ExamScores = new() { 75, 84, 91, 39 }
            },
            new Student {
                ID = 9,
                FirstName = "Svetlana",
                LastName = "Omelchenko", 
                Year = GradeLevel.SecondYear,
                ExamScores = new() { 97, 92, 81, 60 }
            },
            new Student {
                ID = 10,
                FirstName = "Lance",
                LastName = "Tucker",
                Year = GradeLevel.ThirdYear,
                ExamScores = new() { 68, 79, 88, 92 }
            },
            new Student {
                ID = 11,
                FirstName = "Michael",
                LastName = "Tucker",
                Year = GradeLevel.FirstYear,
                ExamScores = new() { 94, 92, 91, 91 }
            },
            new Student {
                ID = 12,
                FirstName = "Eugene", 
                LastName = "Zabokritski",
                Year = GradeLevel.FourthYear,
                ExamScores = new() { 96, 85, 91, 60 }
            }
        };

        public List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Title =	"The Avengers",
                RelaseDate = DateTime.Parse("2012-05-04"),
                Director = "Joss Whedon",
                Budget = 220000000,
                BoxOffice =	1518812988,
                Duration = 143,
                Language = "English",
                Rating = 8.1,
                CreatedAt = DateTime.Parse("2022-10-01 10:00:00"),
                UpdatedAt = DateTime.Parse("2022-10-01 10:00:00")
            },
            new Movie
            {
                Id = 2,
                Title =	"The Dark Knight",
                RelaseDate = DateTime.Parse("2008-07-18"),
                Director = "Christopher Nolan",
                Budget = 185000000,
                BoxOffice =	1004558444,
                Duration = 152,
                Language = "English",
                Rating = 9.0,
                CreatedAt = DateTime.Parse("2022-10-01 10:00:00"),
                UpdatedAt = DateTime.Parse("2022-10-01 10:00:00")
            },
            new Movie
            {
                Id = 3,
                Title = "Spider-Man: No Way Home",
                RelaseDate = DateTime.Parse("2021-12-17"),
                Director = "Jon Watts",
                Budget = 200000000,
                BoxOffice =	1425580358,
                Duration = 148,
                Language = "English",
                Rating = 8.1,
                CreatedAt = DateTime.Parse("2022-10-01 10:00:00"),
                UpdatedAt = DateTime.Parse("2022-10-01 10:00:00") 
            },
            new Movie
            {
                Id = 4,
                Title = "Black Panther",
                RelaseDate = DateTime.Parse("2018-02-16"),
                Director = "Ryan Coogler",
                Budget = 200000000,
                BoxOffice =	1347485216,
                Duration = 134,
                Language = "English",
                Rating = 7.3,
                CreatedAt = DateTime.Parse("2022-10-01 10:00:00"),
                UpdatedAt = DateTime.Parse("2022-10-01 10:00:00")
            },
            new Movie
            {
                Id = 5,
                Title =	"Inception",
                RelaseDate = DateTime.Parse("2010-07-16"),
                Director = "Christopher Nolan",
                Budget = 160000000,
                BoxOffice =	829895144,
                Duration = 148,
                Language = "English",
                Rating = 8.8,
                CreatedAt = DateTime.Parse("2022-10-01 10:00:00"),
                UpdatedAt = DateTime.Parse("2022-10-01 10:00:00") 
            }
        };

        public List<Casts> casts = new List<Casts>
        {
            new Casts { 
                Id = 1, 
                MovieId = 1,
                ActorName = "Robert Downey Jr.",
                CharacterName = "Tony Stark / Iron Man",
                CreatedAt = DateTime.Parse("2022-10-01 10:00:00"), 
                UpdatedAt = DateTime.Parse("2022-10-01 10:00:00") 
            },
            new Casts {
                Id = 2, 
                MovieId = 1, 
                ActorName = "Chris Evans", 
                CharacterName = "Steve Rogers / Captain America", 
                CreatedAt = DateTime.Parse("2022-10-01 10:00:00"), 
                UpdatedAt = DateTime.Parse("2022-10-01 10:00:00") 
            },
            new Casts { 
                Id = 3, 
                MovieId = 1, 
                ActorName = "Scarlett Johansson", 
                CharacterName = "Natasha Romanoff / Black Widow", 
                CreatedAt = DateTime.Parse("2022-10-01 10:00:00"), 
                UpdatedAt = DateTime.Parse("2022-10-01 10:00:00") 
            },
            new Casts {
                Id = 4, 
                MovieId = 2, 
                ActorName = "Dwayne Johnson", 
                CharacterName = "Frank Wolff", 
                CreatedAt = DateTime.Parse("2022-10-01 10:00:00"), 
                UpdatedAt = DateTime.Parse("2022-10-01 10:00:00") 
            },
            new Casts {
                Id = 5, 
                MovieId = 2, 
                ActorName = "Emily Blunt", 
                CharacterName = "Lily Houghton", 
                CreatedAt = DateTime.Parse("2022-10-01 10:00:00"), 
                UpdatedAt = DateTime.Parse("2022-10-01 10:00:00") 
            },
            new Casts {
                Id = 6, 
                MovieId = 2, 
                ActorName = "Jesse Plemons", 
                CharacterName = "Prince Joachim", 
                CreatedAt = DateTime.Parse("2022-10-01 10:00:00"), 
                UpdatedAt = DateTime.Parse("2022-10-01 10:00:00") 
            },
            new Casts {
                Id = 7, 
                MovieId = 3, 
                ActorName = "Tom Holland", 
                CharacterName = "Peter Parker / Spider-Man", 
                CreatedAt = DateTime.Parse("2022-10-01 10:00:00"), 
                UpdatedAt = DateTime.Parse("2022-10-01 10:00:00") 
            },
            new Casts {
                Id = 8, 
                MovieId = 3, 
                ActorName = "Zendaya", 
                CharacterName = "MJ", 
                CreatedAt = DateTime.Parse("2022-10-01 10:00:00"), 
                UpdatedAt = DateTime.Parse("2022-10-01 10:00:00") 
            },
            new Casts { 
                Id = 9, 
                MovieId = 3, 
                ActorName = "Benedict Cumberbatch", 
                CharacterName = "Doctor Strange", 
                CreatedAt = DateTime.Parse("2022-10-01 10:00:00"), 
                UpdatedAt = DateTime.Parse("2022-10-01 10:00:00") 
            }
        };
    }
}