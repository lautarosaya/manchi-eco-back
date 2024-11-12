using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManchiEco.Application.Interfaces
{
    public interface IHomeDataService
    {
        double GetValorTotalCuotas();
        double GetSobrante();
        int GetPorcentajeGustos();
        int GetPorcentajeAhorro();
    }
}
