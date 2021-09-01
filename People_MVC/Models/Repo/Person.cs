using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace People_MVC.Models
{
    public class Person
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get;set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }


        [Required]
        [MaxLength(20)]
        public string TeleNumber { get; set; }
    }
}
