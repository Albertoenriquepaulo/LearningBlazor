using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppDemo.Client.Model
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Summary { get; set; }
        public bool InTheaters { get; set; }
        public string Trailer { get; set; }

        [Required]
        public DateTime? ReleasDate { get; set; }
        public string Poster { get; set; }
        public string TitleBrief
        {
            get
            {
                if (string.IsNullOrEmpty(Title))
                {
                    return null;
                }
                else if (Title.Length > 60)
                {
                    return Title.Substring(0, 600) + "...";
                }
                return Title;
            }
        }
    }
}
