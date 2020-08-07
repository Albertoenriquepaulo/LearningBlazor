using BlazorAppDemo.Client.Model;
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
                new Movie { Title = "Pocoyo", ReleasDate = new DateTime(2015, 7, 2) },
                new Movie { Title = "Superman", ReleasDate = new DateTime(2018, 2, 2) },
                new Movie { Title = "The Schindler List", ReleasDate = new DateTime(2020, 1, 2) }
            };
        }
    }
}
