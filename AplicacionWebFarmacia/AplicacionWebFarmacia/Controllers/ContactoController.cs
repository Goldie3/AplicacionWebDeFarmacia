using Microsoft.AspNetCore.Mvc;

namespace AplicacionWebFarmacia.Controllers
{
    public class ContactoController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}