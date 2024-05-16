using System.ComponentModel.DataAnnotations;

namespace Lab13
{
    public class Producto
    {
        [Required(ErrorMessage = "El Código es Requerido")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El Nombre es Requerido")]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        public string PrecioCompra { get; set; }

        public string PrecioVenta { get; set; }

        public Producto()
        {
            Codigo = string.Empty;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            PrecioCompra = string.Empty;
            PrecioVenta = string.Empty;
        }
    }
}
