using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Rubro
    {
        public int IdRubro { get; set; }
        [Required(ErrorMessage = "Codigo Rubro es Requerido")]
        public string Codigo_Rubro { get; set; }
        [Required(ErrorMessage = "Nombre es Requerido")]
        public string Nombre { get; set; }
    }
}
