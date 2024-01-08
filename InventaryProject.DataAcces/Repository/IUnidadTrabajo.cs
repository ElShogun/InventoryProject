using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaryProject.DataAcces.Repository
{
    public interface IUnidadTrabajo : IDisposable
    {
        IBodegaRepository BodegaRepository { get; }

        Task Guardar();
    }
}
