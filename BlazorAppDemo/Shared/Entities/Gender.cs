using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppDemo.Shared.Entities
{
    public class Gender
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Gender Name field is required.")]
        public string Name { get; set; }
    }
}
