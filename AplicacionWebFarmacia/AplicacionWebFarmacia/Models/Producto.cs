using System.ComponentModel.DataAnnotations;

namespace AplicacionWebFarmacia.Models
{
    public class Producto
    {
        public int idProducto { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        public string nombreProducto { get; set; }
        [Required(ErrorMessage = "La fecha de ingreso es obligatoria.")]
        public DateTime fechaIngreso { get; set; }
        [Required(ErrorMessage = "La cantidad del producto es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad del producto debe ser mayor a cero.")]
        public int cantidadProducto { get; set; }
        [Required(ErrorMessage = "El precio del producto es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El precio del producto debe ser mayor a cero.")]
        public int precio { get; set; }
        [Required(ErrorMessage = "La descripción del producto es obligatoria.")]
        public string descripcion { get; set; }
        [Required(ErrorMessage = "La fecha de vencimiento es obligatoria.")]
        public DateTime fechaVencimiento { get; set; }

        public Producto() { }
        public Producto(int idProducto, string nombreProducto, DateTime fechaIngreso, int cantidadProducto, int precio, string descripcion, DateTime fechaVencimiento)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.fechaIngreso = fechaIngreso;
            this.cantidadProducto = cantidadProducto;
            this.precio = precio;
            this.descripcion = descripcion;
            this.fechaVencimiento = fechaVencimiento;
        }
    }
}
