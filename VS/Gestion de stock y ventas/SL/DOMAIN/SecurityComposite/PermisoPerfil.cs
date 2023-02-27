using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DOMAIN.SecurityComposite
{
    public abstract class PermisoPerfil
    {
        public Nullable<int> Id { get; set; }
        public string Nombre { get; set; }
        public PermisoPerfil() { }
        public abstract void Add(PermisoPerfil permiso);
        public abstract void Remove(PermisoPerfil permiso);
        public abstract int Cantidad_de_permisos { get; }
    }
}
 