using AplicacionWebFarmacia.Models;
using Microsoft.AspNetCore.Mvc;


namespace AplicacionWebFarmacia.Controllers
{
    public class ProductoController : Controller
    {
        List<Producto> listaProductos = new List<Producto>() {
            new Producto(1, "Jarabe", DateTime.Parse("2026-04-30"),20,5000, "Muy bueno para la tos", DateTime.Parse("2028-04-30")),
            new Producto(2, "Paracetamol", DateTime.Parse("2026-02-02"),50,2000, "Alivia el dolor y la fiebre", DateTime.Parse("2027-09-14")),
            new Producto (3, "Alflorex", DateTime.Parse("2026-03-01"),30,1200, "Suplemento para la salud intestinal", DateTime.Parse("2028-03-05")),
            new Producto (4, "Gastrezol", DateTime.Parse("2025-09-25"),30,3000, "Alivia problemas digestivos", DateTime.Parse("2026-09-26")),
            new Producto(5, "Vivera", DateTime.Parse("2025-09-12"),20,1500, "Vitaminas y minerales esenciales", DateTime.Parse("2026-11-17")),
            new Producto(6, "Ozempic", DateTime.Parse("2025-12-01"),60,2650, "Tratamiento para la diabetes tipo 2", DateTime.Parse("2027-08-01")),
            new Producto(7, "Keval Eletriptan", DateTime.Parse("2025-06-25"),15,3000, "Tratamiento para migrañas", DateTime.Parse("2026-05-30")),
            new Producto(8, "Artrosome", DateTime.Parse("2025-08-16"),30,2700, "Suplemento para la salud articular", DateTime.Parse("2027-08-20")),
            new Producto(9, "Arthrozeel", DateTime.Parse("2024-01-01"),56, 1250, "Alivia el dolor articular", DateTime.Parse("2026-01-02")),
            new Producto(10, "Biosul", DateTime.Parse("2023-05-03"),29,2300, "Suplemento vitamínico", DateTime.Parse("2026-11-11"))
            };
        public IActionResult IndexProductos()
        {
            return View(listaProductos);
        }
    }
}
