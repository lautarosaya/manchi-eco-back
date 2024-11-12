using ManchiEco.Application.Interfaces;
using ManchiEco.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManchiEco.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GustosController : BaseController<Gusto, IServiceBase<Gusto>>
    {
        public GustosController(IServiceBase<Gusto> service) : base(service)
        {
        }
    }
}
