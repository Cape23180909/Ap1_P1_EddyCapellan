using System.ComponentModel.DataAnnotations;

namespace Aplicada.Models
{
    public class Articulos
    {
        
        [Key]
        public int ArticuloId { get; set; }
        [Required (ErrorMessage = "Mio, coloque una descripcion")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Mio, coloque un costo")]
        public double Costo { get; set; }
        [Required(ErrorMessage = "Mio, coloque una ganancia")]
        public double Ganancia { get; set; }
        [Required(ErrorMessage = "Mio, coloque un precio")]
        public double Precio { get; set; }


    }
}
