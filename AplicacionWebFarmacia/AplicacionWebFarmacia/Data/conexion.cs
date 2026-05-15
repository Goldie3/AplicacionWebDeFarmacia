using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AplicacionWebFarmacia.Data
{
    public class conexion
    {
        private readonly IConfiguration _config;

        public conexion(IConfiguration config)
        {
            _config = config;
        }

        public MySqlConnection ObtenerConexion()
        {
            string cadena = _config.GetConnectionString("DefaultConnection");
            return new MySqlConnection(cadena);
        }
    }
}
