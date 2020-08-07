using BlazorAppDemo.Client.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppDemo.Client.Pages
{
    public partial class Counter
    {
        [Inject] SingletonServices _singletonServices { get; set; }
        [Inject] TransientServices _transientServices { get; set; }

        private int currentCount = 0;
        List<Movie> movies;


        private void IncrementCount()
        {
            currentCount++;
            _transientServices.Value = currentCount;
            _singletonServices.Value = currentCount;
        }

        protected override void OnInitialized()
        {
            movies = new List<Movie>()
            {
                new Movie { Title = "Tardes Felices", ReleasDate = new DateTime(2018, 5, 5) },
                new Movie { Title = "Show de Fantástico", ReleasDate = new DateTime(1998, 10, 12) },
                new Movie { Title = "Ciudad Bendita", ReleasDate = new DateTime(2007, 11, 1) }
            };

        }
    }
}
