using BlazorAppDemo.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppDemo.Client.Repository
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie { Title = "Pocoyo", ReleasDate = new DateTime(2015, 7, 2), Poster ="https://m.media-amazon.com/images/M/MV5BMTEwODcxMjM0ODNeQTJeQWpwZ15BbWU4MDE5NjI1MDcx._V1_.jpg" },
                new Movie { Title = "Superman", ReleasDate = new DateTime(2018, 2, 2), Poster="https://m.media-amazon.com/images/M/MV5BMzA0YWMwMTUtMTVhNC00NjRkLWE2ZTgtOWEzNjJhYzNiMTlkXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_SY1000_CR0,0,668,1000_AL_.jpg" },
                new Movie { Title = "The Schindler List", ReleasDate = new DateTime(2020, 1, 2), Poster="https://m.media-amazon.com/images/M/MV5BNDE4OTMxMTctNmRhYy00NWE2LTg3YzItYTk3M2UwOTU5Njg4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SY1000_CR0,0,666,1000_AL_.jpg" }
            };
        }
    }
}
