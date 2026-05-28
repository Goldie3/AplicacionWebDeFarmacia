using System.ComponentModel.DataAnnotations;

namespace AplicacionWebFarmacia.Models
{
    public class Producto
    {
        [Display(Name = "ID Producto")]
        public int idProducto { get; set; }

        [Display(Name = "Nombre del Producto")]
        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        public string nombreProducto { get; set; }

        [Display(Name = "Fecha de Ingreso")]
        [Required(ErrorMessage = "La fecha de ingreso es obligatoria.")]
        public DateTime fechaIngreso { get; set; }

        [Display(Name = "Cantidad del Producto")]
        [Required(ErrorMessage = "La cantidad del producto es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad del producto debe ser mayor a cero.")]
        public int cantidadProducto { get; set; }

        [Display(Name = "Precio del Producto")]
        [Required(ErrorMessage = "El precio del producto es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El precio del producto debe ser mayor a cero.")]
        public int precio { get; set; }

        [Display(Name = "Descripción del Producto")]
        [Required(ErrorMessage = "La descripción del producto es obligatoria.")]
        public string descripcion { get; set; }

        [Display(Name = "Fecha de Vencimiento")]
        [Required(ErrorMessage = "La fecha de vencimiento es obligatoria.")]
        public DateTime fechaVencimiento { get; set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "El tipo es obligatorio.")]
        public string tipo { get; set; }

        public Producto() { }
        public Producto(int idProducto, string nombreProducto, DateTime fechaIngreso, int cantidadProducto, int precio, string descripcion, DateTime fechaVencimiento, string tipo)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.fechaIngreso = fechaIngreso;
            this.cantidadProducto = cantidadProducto;
            this.precio = precio;
            this.descripcion = descripcion;
            this.fechaVencimiento = fechaVencimiento;
            this.tipo = tipo;
        }
    }
}
