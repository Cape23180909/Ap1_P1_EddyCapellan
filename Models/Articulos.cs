using System.ComponentModel.DataAnnotations;

namespace Aplicada.Models
{
    public class Articulos
    {
        
        [Key]
        //ArticuloId, Descripcion, Costo, Ganancia y precio
        public int ArticuloId { get; set; }
        [Required (ErrorMessage = "Mio, coloque una descripcion")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Mio, coloque un costo")]
        public decimal? Costo { get; set; }
        [Required(ErrorMessage = "Mio, coloque una ganancia")]
        public decimal? Ganancia { get; set; }
        [Required(ErrorMessage = "Mio, coloque un precio")]
        public decimal? Precio { get; set; }


    }
}
