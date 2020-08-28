using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppDemo.Shared.Entities
{
    public class Person
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }

        [Required] //haciendo este campo nullable hacemos que el control InputDate en la vista no comience con fecha 2001 (PersonForm Component)
        public DateTime? BirthDate { get; set; }

    }
}
