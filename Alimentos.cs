using System.ComponentModel.DataAnnotations;

namespace Lab13
{
    public class Alimentos:Producto
    {
        public DateTime FechaVencimiento { get; set; }

        [Required(ErrorMessage = "La medida es Requerido")]
        public string Medida { get; set; }


        public Alimentos()
        {
            Medida = string.Empty;
        }
    }
}
