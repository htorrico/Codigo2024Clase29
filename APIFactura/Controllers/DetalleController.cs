using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio;
using Entidad;
namespace APIFactura.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DetalleController : ControllerBase
    {
        [HttpPost]
        public void Insert(EDetalle eDetalle)
        {            
            NDetalle nDetalle = new NDetalle();
            nDetalle.Insertar(eDetalle);
        }
    }
}
