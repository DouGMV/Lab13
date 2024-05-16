using System.ComponentModel.DataAnnotations;

namespace Lab13
{
    public class Electronicos:Producto
    {
        [Required(ErrorMessage = "El tiempo de garantia es Requerido")]
        public int TiempoGarantia { get; set; }

        [Required(ErrorMessage = "El Voltaje de garantia es Requerido")]
        public int Voltaje { get; set; }

    }
}
