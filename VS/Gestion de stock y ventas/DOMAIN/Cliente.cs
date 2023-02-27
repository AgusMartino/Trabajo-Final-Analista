using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        [Required(ErrorMessage = "Nombre es Requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Apellido es Requerido")]
        public string Apellido { get; set; }
        public Nullable<DateTime> Fecha_Nacimiento { get; set; }
        [Required(ErrorMessage = "DNI es Requerido")]
        public Nullable<int> Dni { get; set; }
        public string Direccion { get; set; }

    }
}
