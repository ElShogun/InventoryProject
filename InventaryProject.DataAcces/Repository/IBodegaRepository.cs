using InventaryProject.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaryProject.DataAcces.Repository
{
    public interface IBodegaRepository: IRepository<Bodega>
    {
        void Actualizar(Bodega bodega);
    }

}
