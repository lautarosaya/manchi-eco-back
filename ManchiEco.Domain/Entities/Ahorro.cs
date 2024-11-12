using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManchiEco.Domain.Entities
{
    public class Ahorro
    {
        [Key]
        public int AhorroId { get; set; }
        [Required]
        public double Valor { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
