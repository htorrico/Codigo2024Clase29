using Entidad;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace WebApplication1.Controllers
{
    public class CabeceraController : Controller
    {
        public IActionResult Index()
        {
            NCabecera nCabecera = new NCabecera();
            List<ECabecera> eCabeceras = nCabecera.Listar("");

            return View(eCabeceras);
        }
    }
}
