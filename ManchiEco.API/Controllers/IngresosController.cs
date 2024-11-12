using ManchiEco.Application.Interfaces;
using ManchiEco.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManchiEco.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngresosController : BaseController<Ingreso, IServiceBase<Ingreso>>
    {
        public IngresosController(IServiceBase<Ingreso> service) : base(service)
        {
        }
    }
}
