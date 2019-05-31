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
        [StringLength(10, MinimumLength = 9)]
        public String Nombre { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 10)]
        public String Precio { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 10)]
        public String Stock { get; set; }

    }
}