using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManchiEco.Domain.Entities
{
    public class TipoCuota
    {
        [Key]
        public int TipoCuotaId { get; set; }
        [Required]
        public string Nombre { get; set; }
        public bool Vigente { get; set; }
    }
}
