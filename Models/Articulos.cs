using System.ComponentModel.DataAnnotations;

namespace Aplicada.Models
{
    public class Articulos
    {
        
        [Key]
        //ArticuloId, Descripcion, Costo, Ganancia y precio
        public int ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public decimal? Costo { get; set; }
        public decimal? Ganancia { get; set; }
        public decimal? Precio { get; set; }

        


    }
}
