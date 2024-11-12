using ManchiEco.Application.Interfaces;
using ManchiEco.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManchiEco.Application.Services
{
    public class CuotasService: ICuotaService
    {
        private readonly IServiceBase<Cuota> _cuotaService;
        public CuotasService(IServiceBase<Cuota> cuotaService)
        {
            _cuotaService = cuotaService;
        }

        public List<Cuota> GetCuotasVigentes()
        {
            List<Cuota> cuotasVigentes = _cuotaService.GetAll().Where(cuota => cuota.Vigente == true).ToList();

            if(cuotasVigentes.Count == 0 || cuotasVigentes is null)
                throw new FileNotFoundException("No se encontraron cuotas vigentes");

            return cuotasVigentes;
        }
    }
}
