using ManchiEco.Application.Interfaces;
using ManchiEco.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManchiEco.Application.Services
{
    public class HomeDataService: IHomeDataService
    {
        private readonly ICuotaService _cuotaService;
        private readonly IIngresosService _ingresosService;
        private readonly IServiceBase<Porcentaje> _serviceBase;
        public HomeDataService(ICuotaService cuotaService, IIngresosService ingresosService, IServiceBase<Porcentaje> serviceBase)
        {
            _cuotaService = cuotaService;
            _ingresosService = ingresosService;
            _serviceBase = serviceBase;
        }

        public double GetValorTotalCuotas()
        {
            double totalCuentas = _cuotaService.GetCuotasVigentes().Sum(c => c.Valor);

            return totalCuentas;
        }

        public double GetSobrante()
        {
            double sueldo = _ingresosService.GetIngresoVigente().Valor;
            double sobrante = sueldo - this.GetValorTotalCuotas();

            return sobrante;
        }       
        
        public int GetPorcentajeGustos()
        {
            var porcentajeVigente = _serviceBase.GetAll().OrderByDescending(x => x.FechaIngreso).Where(por => por.Vigente == true).FirstOrDefault();

            if (porcentajeVigente is null)
                throw new FileNotFoundException("No se ha encontrado el porcentaje de gustos vigente");

            int porcentajeGustos = porcentajeVigente.Gustos;
            
            return porcentajeGustos;
        }

        public int GetPorcentajeAhorro()
        {
            var porcentajeVigente = _serviceBase.GetAll().OrderByDescending(x => x.FechaIngreso).Where(por => por.Vigente == true).FirstOrDefault();

            if (porcentajeVigente is null)
                throw new FileNotFoundException("No se ha encontrado el porcentaje de ahorros vigente");

            int porcentajeAhorro = porcentajeVigente.Ahorro;

            return porcentajeAhorro;
        }
    }
}
