using AplicacionWebFarmacia.Data;
using AplicacionWebFarmacia.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;


namespace AplicacionWebFarmacia.Controllers
{
    public class ProductoController : Controller
    {
        private readonly conexion _conexion;

        public ProductoController(conexion conexion)
        {
            _conexion = conexion;
        }
        public IActionResult IndexProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            using (MySqlConnection conn = _conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM producto";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaProductos.Add(new Producto()
                    {
                        idProducto = reader.GetInt32("idproducto"),
                        nombreProducto = reader.GetString("nombre"),
                        fechaIngreso = reader.GetDateTime("fechaIngreso"),
                        cantidadProducto = reader.GetInt32("cantidadProducto"),
                        precio = reader.GetInt32("precio"),
                        descripcion = reader.GetString("descripcion"),
                        fechaVencimiento = reader.GetDateTime("fechaVencimiento")
                    });

                }
            }
            return View(listaProductos);
        }
    }
}
