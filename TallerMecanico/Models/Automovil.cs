using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace TallerMecanico.Models
{
    public class Automovil
    {
        public int Id { get; set; }


        [Required]
        [RangeAttribute(0, 100000000)]
        public int Precio { get; set; }

        [Required]
        [RangeAttribute(0, 1000)]
        public int Stock { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 9)]
        public String Patente { get; set; }


        [Required]
        [StringLength(30, MinimumLength = 4)]
        public String Modelo { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 4)]
        public String Color { get; set; }


        [Required]
        [RangeAttribute(1900, 2100)]
        public int Anio { get; set; }

    }
}