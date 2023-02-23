using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqBasicBeginner.Data;
using LinqBasicBeginner.ModelDtos;
using LinqBasicBeginner.Models;

namespace LinqBasicBeginner
{
    public class MovieService
    {
        private readonly Datas _data;
        public MovieService()
        {
            _data = new Datas();
        }

        public List<MovieDto> GetAll()
        {
            var result = (from movie in _data.movies
                select MapToMovieDto(movie)).ToList();

            return result;
        }

        public MovieDto? GetMovieById(int id)
        {
            var result = (from movie in _data.movies
                where movie.Id == id
                select MapToMovieDto(movie)).FirstOrDefault();

            if (result == null)
            {
                throw new ApplicationException("Not Found");
            }
            
            return result;
        }
        
        public List<MovieDto> MovieFilterContain(string contain)
        {
            var result = (from movie in _data.movies
                where movie.Title.ToLower().Contains(contain.ToLower())
                select MapToMovieDto(movie)).ToList();
            
            return result;
        }

        public List<MovieDto> MovieDuration(int duration)
        {
            var result = (from movie in _data.movies
                where movie.Duration > duration
                select MapToMovieDto(movie)).ToList();
            
            return result;
        }

        private static MovieDto MapToMovieDto(Movie movie)
        {
            return new MovieDto
            {
                Title = movie.Title,
                RelaseDate = movie.RelaseDate,
                Director = movie.Director,
                Budget = movie.Budget,
                BoxOffice = movie.BoxOffice,
                Duration = movie.Duration,
                Language = movie.Language,
                Rating = movie.Rating
            };
        }
        
    }
}