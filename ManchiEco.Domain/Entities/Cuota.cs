using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManchiEco.Domain.Entities
{
    public class Cuota
    {
        [Key]
        public int CuotaId { get; set; }
        [Required]
        public int TipoCuotaId { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public int NroCuotas { get; set; }
        [Required]
        public double Valor { get; set; }
        [Required]
        public bool Vigente { get; set; }
    }
}
