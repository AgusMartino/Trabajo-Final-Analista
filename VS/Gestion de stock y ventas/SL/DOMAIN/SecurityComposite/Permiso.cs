using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DOMAIN.SecurityComposite
{
     public class Permiso : PermisoPerfil
    {
        public string vista { get; set; }
        public override int Cantidad_de_permisos => 0;

        public override void Add(PermisoPerfil permiso)
        {
            throw new NotImplementedException("No se puede agregar elementos en un permiso.");
        }

        public override void Remove(PermisoPerfil permiso)
        {
            throw new NotImplementedException("No se puede quitar elementos en un permiso.");
        }
    }
}
