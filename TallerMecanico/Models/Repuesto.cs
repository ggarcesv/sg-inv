using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace TallerMecanico.Models
{
    public class Repuesto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public String Nombre { get; set; }

        [Required]
        [RangeAttribute(0, 10000000)]
        public int Precio { get; set; }


        [Required]
        [RangeAttribute(0, 999)]
        public int Stock { get; set; }

    }
}