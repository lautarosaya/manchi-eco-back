using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManchiEco.Domain.Entities
{
    public class Porcentaje
    {
        [Key]
        public int PorcentajeID { get; set; }
        [Required]
        [Range(0, 100)]
        public int Ahorro { get; set; }
        [Required]
        [Range(0, 100)]
        public int Gustos { get; set; }
        [Required]
        public DateTime FechaIngreso { get; set; }
        [Required]
        public bool Vigente { get; set; }
    }
}
