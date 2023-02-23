using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqBasicBeginner.Data;
using Xunit;

namespace LinqBasicBeginner.Test
{
    public class MovieTest
    {
        [Fact]
        public void MovieByIdSucces()
        {
            var data = new Datas();
            var service = new MovieService();

            Assert.Equal(data.movies.Find(m => m.Id == 1)?.Title, service.GetMovieById(1)?.Title);
        }

        [Fact]
        public void MovieByIdTestExcep()
        {
            var service = new MovieService();
            int id = 7;

            Assert.Throws<ApplicationException>(() => service.GetMovieById(id));
        }
    }
}