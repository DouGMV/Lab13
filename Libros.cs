using System.ComponentModel.DataAnnotations;

namespace Lab13
{
    public class Libros:Producto
    {
        [Required(ErrorMessage = "La Editorial es Requerido")]
        public string Editorial { get; set; }

        [Required(ErrorMessage = "La Categoria es Requerido")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "El Autor es Requerido")]
        public string Autor { get; set; }


        public Libros()
        {
            Editorial = string.Empty;
            Categoria = string.Empty;
            Autor = string.Empty;
        }
    }
}
