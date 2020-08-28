using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppDemo.Shared.Entities
{
    public class MovieGender
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int GenderId { get; set; }
        public Movie Movie { get; set; }
        public Gender Gender { get; set; }

    }
}
