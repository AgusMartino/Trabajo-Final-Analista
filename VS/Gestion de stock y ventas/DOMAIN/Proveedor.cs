using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        [Required(ErrorMessage = "Nombre es Requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Cuit es Requerido")]
        public Nullable<Int64> Cuit { get; set; }
    }
}
