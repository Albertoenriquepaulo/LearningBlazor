using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppDemo.Client.Model
{
    public class Movie
    {
        public int Id { get; set; } = 1;
        public string Title { get; set; }
        public DateTime ReleasDate { get; set; }
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
