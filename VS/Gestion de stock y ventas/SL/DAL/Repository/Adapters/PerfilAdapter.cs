using SL.DAL.Contracts;
using SL.DOMAIN.SecurityComposite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Repository.Adapters
{
    public class PerfilAdapter : IEntityAdapter<Perfil>
    {
        #region Singleton

        private readonly static PerfilAdapter _instance = new PerfilAdapter();

            public static PerfilAdapter Current
            {
                get
                {
                    return _instance;
                }
            }

            private PerfilAdapter()
            {
                //Implent here the initialization of your singleton
            }
        #endregion

        public Perfil Adapt(object[] values)
        {
            Perfil perfil = new Perfil();
            perfil.Id = int.Parse(values[(int)Colums.IdPerfil].ToString());
            perfil.Nombre = values[(int)Colums.nombre].ToString();

            List<Permiso> PermisosRelacionados = new Permiso_PerfilRepository().GetPermisos(perfil);

            foreach (var item in PermisosRelacionados)
            {
                perfil.Add(item);
            }

            List<Perfil> perfilesRelacionados = new Perfil_PerfilRepository().Get(perfil);
            foreach(var item in perfilesRelacionados)
            {
                perfil.Add(item);
            }
            return perfil;

        }
        private enum Colums
        {
            IdPerfil,
            nombre
        }
    }
}
