using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqBasicBeginner.Data;
using LinqBasicBeginner.ModelDtos;
using LinqBasicBeginner.Models;

namespace LinqBasicBeginner
{
    public class MovieCastService
    {
        private readonly Datas _data;
        public MovieCastService()
        {
            _data = new Datas();
        }

        public List<MovieCastDto> GetAll()
        {
            var result = (from movie in _data.movies
                join cast in _data.casts on movie.Id equals cast.MovieId
                select MapToMovieCastDto(movie, cast)).ToList();

            return result;
        }

        public List<MovieCastDto> GetMovieCastByMovieId(int movieId)
        {
            var result = (from movie in _data.movies
                join cast in _data.casts on movie.Id equals cast.MovieId
                where movie.Id == movieId
                select MapToMovieCastDto(movie, cast)).ToList();

            if (result == null)
            {
                throw new ApplicationException("Data Not Found");
            }

            return result;
        }

        private static MovieCastDto MapToMovieCastDto(Movie movie, Casts cast)
        {
            return new MovieCastDto
            {
                Title = movie.Title,
                RelaseDate = movie.RelaseDate,
                Director = movie.Director,
                Budget = movie.Budget,
                BoxOffice = movie.BoxOffice,
                Duration = movie.Duration,
                Language = movie.Language,
                Rating = movie.Rating,
                ActorName = cast.ActorName,
                CharacterName = cast.CharacterName
            };
        }
    }
}