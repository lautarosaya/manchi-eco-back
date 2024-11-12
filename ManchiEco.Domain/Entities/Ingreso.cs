using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManchiEco.Domain.Entities
{
    public class Ingreso
    {
        [Key]
        public int IngresoId { get; set; }
        [Required]
        public double Valor { get; set; }
        [Required]
        public DateTime FechaIngreso { get; set; }
        [Required]
        public bool Vigente { get; set; }
    }
}
