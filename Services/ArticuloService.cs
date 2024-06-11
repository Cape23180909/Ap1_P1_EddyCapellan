using Aplicada.DAL;
using Microsoft.EntityFrameworkCore;
using Aplicada.Models;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq.Expressions;
using System.Linq;
using System.Diagnostics.Metrics;

namespace Aplicada.Services
{
    public class ArticuloService
    {
        private readonly Contexto Contexto;
        public ArticuloService (Contexto contexto)
        {
            Contexto = contexto;
        }
        //Metodo Existe 
        public async Task <bool> Existe (int ArticuloId)
        {
            return await Contexto.Articulos.AnyAsync (a =>a.ArticuloId == ArticuloId);
        }
        //Metodo Insertar
        public async Task <bool> Insertar (Articulos articulos)
        {
            Contexto.Articulos.Add (articulos);
            return await Contexto.SaveChangesAsync () > 0;
        }
        //Metodo modificar
        public async Task <bool> Modificar (Articulos articulos)
        {
            Contexto.Articulos.Update(articulos);
            var Modificado = await Contexto.SaveChangesAsync () > 0;
            Contexto.Entry(articulos).State = EntityState.Detached;
            return Modificado;
             
        }
        //Metodo Guardar
        public async Task <bool> Guardar (Articulos articulos)
        {
            if (!await Existe (articulos.ArticuloId))
                return await Insertar (articulos);
            else 
                return await Modificar (articulos);
        }
        //Metodo eliminar 
        public async Task <bool> Eliminar (int id)
        {
            var EliminarArticulo = await Contexto.Articulos
                .Where(a =>a.ArticuloId==id)
                .ExecuteDeleteAsync();
            return EliminarArticulo > 0;
        }
        // Metodo buscar 
        public async Task <Articulos?> Buscar (int id)
        {
            return await Contexto.Articulos
                .AsNoTracking()
                .FirstOrDefaultAsync ();
        }
        //Metodo Listar 
        public async Task<List<Articulos>> Listar(Expression<Func<Articulos, bool>> criterio)
        {
            return await Contexto.Articulos
                .Where(criterio)
                .ToListAsync();
        }
    }
}