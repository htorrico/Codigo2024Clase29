using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entidad;
using Negocio;

namespace APIFactura.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CabeceraController : ControllerBase
    {
        [HttpGet]
        public List<ECabecera> Listar(string cliente,string vendedor)
        {
            NCabecera nCabecera = new NCabecera();
            List<ECabecera> eCabeceras = nCabecera.Listar(cliente);
            return eCabeceras;
        }

     



    }
}
