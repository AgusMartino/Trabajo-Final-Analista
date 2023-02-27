using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        [Required(ErrorMessage = "Codigo Servicio es Requerido")]
        public string CodigoServicio { get; set; }
        [Required(ErrorMessage = "Nombre es Requerido")]
        public string Nombre { get; set; }

    }
}
