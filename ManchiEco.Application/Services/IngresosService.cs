using ManchiEco.Application.Interfaces;
using ManchiEco.Domain.Entities;
using ManchiEco.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManchiEco.Application.Services
{
    public class IngresosService: IIngresosService
    {        
        private readonly IServiceBase<Ingreso> _ingresoService;

        public IngresosService(IServiceBase<Ingreso> ingresoService)
        {
            _ingresoService = ingresoService;
        }

        public Ingreso GetIngresoVigente()
        {
            Ingreso ingresoVigente = _ingresoService.GetAll().OrderByDescending(i => i.FechaIngreso).Where(ingreso => ingreso.Vigente == true).FirstOrDefault()!;

            if(ingresoVigente is null)
                throw new FileNotFoundException("No se encontró un ingreso vigente");

            return ingresoVigente;
        }
    }
}
