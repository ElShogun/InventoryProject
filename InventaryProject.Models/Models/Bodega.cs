using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaryProject.Models.Models
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nombre es requierido")]
        [MaxLength(60, ErrorMessage = "Nombre de maximo 60 caracteres")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Descripcion es requierido")]
        [MaxLength(100, ErrorMessage = "Descripcion de maximo 100 caracteres")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Estado es requerido")]
        public bool Estado { get; set; }
    }
}
