using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DOMAIN.SecurityComposite
{
    public class Usuario
    {
        public Nullable<int> IdUsuario { get; set; }
        public string usuario { get; set; }
        public string Contraseña { get; set; }
        public Nullable<bool> Habilitado { get; set; }
        public List<PermisoPerfil> Permisos { get; set; } = new List<PermisoPerfil>();
        public List<Permiso> PermisoMenu
        {
            get
            {
                List<Permiso> listadoAux = new List<Permiso>();
                ObtenerListadoPatentes(Permisos, listadoAux);
                return listadoAux;
            }
        }
        public List<Perfil> Roles
        {
            get
            {
                List<Perfil> listadoAux = new List<Perfil>();
                ObtenerListadoFamilias(Permisos, listadoAux);
                return listadoAux;
            }
        }
        private void ObtenerListadoPatentes(List<PermisoPerfil> lstPermisosPorGrupo, List<Permiso> listadoAux)
        {
            foreach(var permisoitem in lstPermisosPorGrupo)
            {
                if(permisoitem.Cantidad_de_permisos == 0)
                {
                    listadoAux.Add(permisoitem as Permiso);
                }
                if(permisoitem.Cantidad_de_permisos > 0)
                {
                    ObtenerListadoPatentes((permisoitem as Perfil).ListadoPermisos, listadoAux);
                }
            }
        }
        private void ObtenerListadoFamilias(List<PermisoPerfil> lstPermisosPorGrupo, List<Perfil> listadoAux)
        {
            foreach (var permisoitem in lstPermisosPorGrupo)
            {
                if (permisoitem.Cantidad_de_permisos > 0)
                {
                    listadoAux.Add(permisoitem as Perfil);
                    ObtenerListadoFamilias((permisoitem as Perfil).ListadoPermisos, listadoAux);
                }
            }
        }
    }
}
