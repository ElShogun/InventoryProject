using InventaryProject.DataAcces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaryProject.DataAcces.Repository
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        private readonly ApplicationDbContext _context;

        public IBodegaRepository _bodegaRepository {  get; private set; }

        public UnidadTrabajo(ApplicationDbContext db)
        {
            _context = db;
            _bodegaRepository = new BodegaRepository(db);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task Guardar()
        {
            await _context.SaveChangesAsync();
        }
    }
}
