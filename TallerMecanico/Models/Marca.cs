using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace TallerMecanico.Models
{
    public class Marca
    {

        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 4)]
        public String Nombre { get; set; }

        public virtual ICollection<Automovil> Automoviles { get; set; }

       
    }
}