using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManchiEco.Domain.Entities
{
    public class Gusto
    {
        [Key]
        public int GustoId { get; set; }
        [Required]
        public double Valor { get; set; }
        [Required]
        public DateTime FechaIngreso { get; set; }
    }
}
