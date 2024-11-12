using ManchiEco.API.DTOs;
using ManchiEco.Application.Interfaces;
using ManchiEco.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManchiEco.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeDataController : ControllerBase
    {
        private readonly IIngresosService _ingresosService;
        private readonly ICuotaService _cuotaService;
        private readonly IHomeDataService _homeDataService;

        public HomeDataController(IIngresosService ingresosService, ICuotaService cuotaService, IHomeDataService homeDataService)
        {
            _ingresosService = ingresosService;
            _cuotaService = cuotaService;
            _homeDataService = homeDataService;
        }
        [HttpGet]
        public ActionResult<HomeDataDTO> GetInitialData()
        {
            double sueldoVigente = _ingresosService.GetIngresoVigente().Valor;
            double totalCuentas = _homeDataService.GetValorTotalCuotas();
            List<Cuota> cuotasVigentes = _cuotaService.GetCuotasVigentes();
            double sobrante = _homeDataService.GetSobrante();
            int gustos = _homeDataService.GetPorcentajeGustos();
            int ahorro = _homeDataService.GetPorcentajeAhorro();

            HomeDataDTO result = new HomeDataDTO
            {
                SueldoVigente = sueldoVigente,
                CuotaTotal = totalCuentas,
                Cuotas = cuotasVigentes,
                Sobrante = sobrante,
                Gustos = (sobrante * gustos) / 100,
                Ahorro = (sobrante * ahorro) / 100,
            };

            return Ok(result);
        }
    }
}
