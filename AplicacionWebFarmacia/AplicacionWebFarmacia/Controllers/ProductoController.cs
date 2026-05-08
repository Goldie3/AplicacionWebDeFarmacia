using AplicacionWebFarmacia.Models;
using Microsoft.AspNetCore.Mvc;


namespace AplicacionWebFarmacia.Controllers
{
    public class ProductoController : Controller
    {
        List<Producto> listaProductos = new List<Producto>() {
            new Producto(1, "Jarabe", DateTime.Parse("2026-04-30"),20,5000, "Muy bueno para la tos"),
            new Producto(2, "Paracetamol", DateTime.Parse("2026-02-02"),50,2000, "Alivia el dolor y la fiebre"),
            new Producto (3, "Alflorex", DateTime.Parse("2026-03-01"),30,1200, "Suplemento para la salud intestinal"),
            new Producto (4, "Gastrezol", DateTime.Parse("2025-09-25"),30,3000, "Alivia problemas digestivos"),
            new Producto(5, "Vivera", DateTime.Parse("2025-09-12"),20,1500, "Vitaminas y minerales esenciales"),
            new Producto(6, "Ozempic", DateTime.Parse("2025-12-01"),60,2650, "Tratamiento para la diabetes tipo 2"),
            new Producto(7, "Keval Eletriptan", DateTime.Parse("2025-06-25"),15,3000, "Tratamiento para migrañas"),
            new Producto(8, "Artrosome", DateTime.Parse("2025-08-16"),30,2700, "Suplemento para la salud articular"),
            new Producto(9, "Arthrozeel", DateTime.Parse("2024-01-01"),56, 1250, "Alivia el dolor articular"),
            new Producto(10, "Biosul", DateTime.Parse("2023-05-03"),29,2300, "Suplemento vitamínico")
            };
        public IActionResult IndexProductos()
        {
            return View(listaProductos);
        }
    }
}
