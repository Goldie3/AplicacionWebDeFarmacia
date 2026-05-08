namespace AplicacionWebFarmacia.Models
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public DateTime fechaIngreso { get; set; }
        public int cantidadProducto { get; set; }
        public int precio { get; set; }

        public string descripcion { get; set; }
    public Producto(int idProducto, string nombreProducto, DateTime fechaIngreso, int cantidadProducto, int precio, string descripcion)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.fechaIngreso = fechaIngreso;
            this.cantidadProducto = cantidadProducto;
            this.precio = precio;
            this.descripcion = descripcion;
        }
        
    }
}
