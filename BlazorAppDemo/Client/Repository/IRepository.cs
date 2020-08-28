using BlazorAppDemo.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppDemo.Client.Repository
{
    public interface IRepository
    {
        List<Movie> GetMovies();
    }
}
