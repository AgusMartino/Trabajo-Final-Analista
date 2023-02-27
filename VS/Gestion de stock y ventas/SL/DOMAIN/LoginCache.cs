using SL.DOMAIN.SecurityComposite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DOMAIN
{
    public static class LoginCache 
    {
        public static Nullable<int> IdUsuario { get; set; }
        public static string Usuario { get; set; }
        public static string Contraseña { get; set; }
        public static Nullable<bool> Habilitado { get; set; }
        public static string Codigo_idioma { get; set; }
        public static List<PermisoPerfil> Permisos { get; set; } = new List<PermisoPerfil>();
        public static List<Permiso> PermisoMenu
        {
            get
            {
                List<Permiso> listadoAux = new List<Permiso>();
                ObtenerListadoPatentes(Permisos, listadoAux);
                return listadoAux;
            }
        }
        public static List<Perfil> Roles
        {
            get
            {
                List<Perfil> listadoAux = new List<Perfil>();
                ObtenerListadoFamilias(Permisos, listadoAux);
                return listadoAux;
            }
        }
        private static void ObtenerListadoPatentes(List<PermisoPerfil> lstPermisosPorGrupo, List<Permiso> listadoAux)
        {
            foreach (var permisoitem in lstPermisosPorGrupo)
            {
                if (permisoitem.Cantidad_de_permisos == 0)
                {
                    listadoAux.Add(permisoitem as Permiso);
                }
                if (permisoitem.Cantidad_de_permisos > 0)
                {
                    ObtenerListadoPatentes((permisoitem as Perfil).ListadoPermisos, listadoAux);
                }
            }
        }
        private static void ObtenerListadoFamilias(List<PermisoPerfil> lstPermisosPorGrupo, List<Perfil> listadoAux)
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
