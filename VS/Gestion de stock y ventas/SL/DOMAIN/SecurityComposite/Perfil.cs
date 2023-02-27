using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DOMAIN.SecurityComposite
{
    public class Perfil : PermisoPerfil
    {
        private List<PermisoPerfil> permisos = new List<PermisoPerfil>();
        public List<PermisoPerfil> ListadoPermisos => permisos;
        public override int Cantidad_de_permisos => permisos.Count;
        public Perfil() { }

        public Perfil(PermisoPerfil permisoPerfil)
        {
            permisos.Add(permisoPerfil);
        }
        public override void Add(PermisoPerfil permiso)
        {
            permisos.Add(permiso);
        }

        public override void Remove(PermisoPerfil permiso)
        {
            permisos.Remove(permiso);
        }
    }
}
