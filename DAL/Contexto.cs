using Aplicada.Models;
using Microsoft.EntityFrameworkCore;

namespace Aplicada.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options) { }

        public DbSet <Articulos> articulos { get; set; }
    }
}
