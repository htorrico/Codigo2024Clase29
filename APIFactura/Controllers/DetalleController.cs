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
        public bool Insert(EDetalle eDetalle)
        {
            try
            {
                NDetalle nDetalle = new NDetalle();
                nDetalle.Insertar(eDetalle);
                return true;
            }
            catch (Exception)
            {

                return false;
            }     
           
        }
        [HttpPost]
        public string Insert2(EDetalle eDetalle)
        {
            try
            {
                NDetalle nDetalle = new NDetalle();
                nDetalle.Insertar(eDetalle);
                return "Registro Exitoso";
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }

        }
    }
}
