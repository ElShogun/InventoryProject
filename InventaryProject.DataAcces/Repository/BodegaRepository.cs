using InventaryProject.DataAcces.Data;
using InventaryProject.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaryProject.DataAcces.Repository
{
    public class BodegaRepository : Repository<Bodega>, IBodegaRepository
    {
        private readonly ApplicationDbContext _context;

        public BodegaRepository(ApplicationDbContext dbContext): base(dbContext) { _context = dbContext }
        public void Actualizar(Bodega bodega)
        {
            var bodegaBD = _context.Bodegas.FirstOrDefault(b => b.Id == bodega.Id);
            if (bodegaBD != null)
            {
                bodegaBD.Nombre = bodega.Nombre;
                bodegaBD.Descripcion = bodega.Descripcion;
                bodegaBD.Estado = bodega.Estado;
                _context.SaveChanges();
            }
        }
    }
}
