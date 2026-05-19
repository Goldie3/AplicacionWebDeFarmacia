using AplicacionWebFarmacia.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AplicacionWebFarmacia.Models;
using MySql.Data.MySqlClient;

namespace AplicacionWebFarmacia.Controllers
{
    public class CRUDController : Controller
    {
        private readonly conexion _conexion;
        public CRUDController(conexion conexion)
        {
            _conexion = conexion;
        }
        // GET: CRUDController
        public ActionResult Index(ProductoController producto)
        {
            return View();
        }

        // GET: CRUDController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CRUDController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CRUDController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Producto producto)
        {
            using(MySqlConnection conn = _conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO producto (nombre, fechaIngreso, cantidadProducto, precio, descripcion, fechaVencimiento)" +
                    "VALUES (@nombre, @fechaIngreso, @cantidadProducto, @precio, @descripcion, @fechaVencimiento)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", producto.nombreProducto);
                cmd.Parameters.AddWithValue("@fechaIngreso", producto.fechaIngreso);
                cmd.Parameters.AddWithValue("@cantidadProducto", producto.cantidadProducto);
                cmd.Parameters.AddWithValue("@precio", producto.precio);
                cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
                cmd.Parameters.AddWithValue("@fechaVencimiento", producto.fechaVencimiento);

                cmd.ExecuteNonQuery();
            }
            try
            {
                return RedirectToAction();
            }
            catch
            {
                return View();
            }
        }

        // GET: CRUDController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CRUDController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CRUDController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CRUDController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
