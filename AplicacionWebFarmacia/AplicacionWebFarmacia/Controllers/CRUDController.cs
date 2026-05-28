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
        public ActionResult Index()
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
                string query = "INSERT INTO producto (nombre, fechaIngreso, cantidadProducto, precio, descripcion, fechaVencimiento, tipo)" +
                    "VALUES (@nombre, @fechaIngreso, @cantidadProducto, @precio, @descripcion, @fechaVencimiento, @tipo)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", producto.nombreProducto);
                cmd.Parameters.AddWithValue("@fechaIngreso", producto.fechaIngreso);
                cmd.Parameters.AddWithValue("@cantidadProducto", producto.cantidadProducto);
                cmd.Parameters.AddWithValue("@precio", producto.precio);
                cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
                cmd.Parameters.AddWithValue("@fechaVencimiento", producto.fechaVencimiento);
                cmd.Parameters.AddWithValue("@tipo", producto.tipo);

                cmd.ExecuteNonQuery();
            }

            TempData["Mensaje"] = "Producto creado exitosamente.";
            TempData["Tipo"] = "success";

            return RedirectToAction("IndexProductos", "Producto");
        }

        // GET: CRUDController/Edit/5
        public ActionResult Edit(int idProducto)
        {

            using (MySqlConnection conn = _conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM producto WHERE idproducto = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idProducto);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Producto producto = new Producto()
                    {
                        idProducto = reader.GetInt32("idproducto"),
                        nombreProducto = reader.GetString("nombre"),
                        fechaIngreso = reader.GetDateTime("fechaIngreso"),
                        cantidadProducto = reader.GetInt32("cantidadProducto"),
                        precio = reader.GetInt32("precio"),
                        descripcion = reader.GetString("descripcion"),
                        fechaVencimiento = reader.GetDateTime("fechaVencimiento"),
                        tipo = reader.GetString("tipo")
                    };
                    return View(producto);
                }

                {
                    return View();
                }
            }
        }
        // POST: CRUDController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idProducto, Producto producto)
        {
            using (MySqlConnection conn = _conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE producto SET nombre = @nombre, fechaIngreso = @fechaIngreso, cantidadProducto = @cantidadProducto, precio = @precio, descripcion = @descripcion, fechaVencimiento = @fechaVencimiento, tipo = @tipo WHERE idproducto = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idProducto);
                cmd.Parameters.AddWithValue("@nombre", producto.nombreProducto);
                cmd.Parameters.AddWithValue("@fechaIngreso", producto.fechaIngreso);
                cmd.Parameters.AddWithValue("@cantidadProducto", producto.cantidadProducto);
                cmd.Parameters.AddWithValue("@precio", producto.precio);
                cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
                cmd.Parameters.AddWithValue("@fechaVencimiento", producto.fechaVencimiento);
                cmd.Parameters.AddWithValue("@tipo", producto.tipo);

                cmd.ExecuteNonQuery();
            }
            TempData["Mensaje"] = "Producto actualizado correctamente.";
            TempData["Tipo"] = "success";
            return RedirectToAction("IndexProductos", "Producto");
        }

        // GET: CRUDController/Delete/5
        public ActionResult Delete(int idProducto)
        {
            using (MySqlConnection conn = _conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM producto WHERE idproducto = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idProducto);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Producto producto = new Producto()
                    {
                        idProducto = reader.GetInt32("idproducto"),
                        nombreProducto = reader.GetString("nombre"),
                        fechaIngreso = reader.GetDateTime("fechaIngreso"),
                        cantidadProducto = reader.GetInt32("cantidadProducto"),
                        precio = reader.GetInt32("precio"),
                        descripcion = reader.GetString("descripcion"),
                        fechaVencimiento = reader.GetDateTime("fechaVencimiento"),
                        tipo = reader.GetString("tipo")
                    };
                    return View(producto);
                }
                TempData["Mensaje"] = "Producto eliminado con exito.";
                TempData["MensajeTipo"] = "success";
                return RedirectToAction("IndexProductos", "Producto");
            }
        }
        // POST: CRUDController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int idProducto, IFormCollection collection)
        {
            using (MySqlConnection conn = _conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM producto WHERE idproducto = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idProducto);
                cmd.ExecuteNonQuery();
            }
            try
            {
                TempData["Mensaje"] = "Producto eliminado con exito.";
                TempData["Tipo"] = "success";
                return RedirectToAction("IndexProductos", "Producto");
            }
            catch
            {
                return View();
            }
        }
    }
}
