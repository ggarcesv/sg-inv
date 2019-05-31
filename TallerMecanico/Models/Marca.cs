using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerMecanico.Models
{
    public class Marca
    {

        public int Id { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 9)]
        public String Patente { get; set; }


        [Required]
        [StringLength(25, MinimumLength = 10)]
        public String Modelo { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 10)]
        public String Color { get; set; }


        [Required]
        [RangeAttribute(0, 100)]
        public int Anio { get; set; }

    }
}