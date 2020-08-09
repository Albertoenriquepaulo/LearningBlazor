using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppDemo.Client.Helpers
{
    //Class used for Cascading Parameter purpose
    public class CssParam
    {
        public string Color { get; set; } = "red";
        public string Size { get; set; } = "12px";

        public CssParam()
        {
        }

        public CssParam(string color, string size)
        {
            Color = color;
            Size = size;
        }
    }
}
