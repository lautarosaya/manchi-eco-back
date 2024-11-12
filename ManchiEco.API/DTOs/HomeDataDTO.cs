using ManchiEco.Domain.Entities;

namespace ManchiEco.API.DTOs
{
    public class HomeDataDTO
    {
        public double SueldoVigente { get; set; }
        public double CuotaTotal { get; set; }
        public List<Cuota> Cuotas { get; set; }
        public double Sobrante { get; set; }
        public double Gustos { get; set; }
        public double Ahorro { get; set; }
    }
}
