using SL.DAL.Contracts;
using SL.DAL.Repository;
using SL.DOMAIN.SecurityComposite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Factories
{

    public sealed class Factory
    {
        #region Singleton
        private readonly static Factory _instance = new Factory();

        public static Factory Current
        {
            get
            {
                return _instance;
            }
        }

        private Factory()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
        //public IGenericRepository<Patente> PatenteRepository { get; set; }
        //public IGenericRepository<Familia> FamiliaRepository { get; set; }
        public IUsuarioRepository<Usuario> GetUsuarioRepository()
        {
            string backend = ConfigurationManager.AppSettings["backendSL"];
            if (backend == "SL.DAL.Repository")
            {
                return new UsuarioRepository();
            }
            else
            {
                return null;
            }
        }
        public IGenericRepository<Permiso> GetPermisoRepository()
        {
            string backend = ConfigurationManager.AppSettings["backendSL"];
            if (backend == "SL.DAL.Repository")
            {
                return new PermisoRepository();
            }
            else
            {
                return null;
            }
        }
        public IGenericRepository<Perfil> GetPerfilRepository()
        {
            string backend = ConfigurationManager.AppSettings["backendSL"];
            if (backend == "SL.DAL.Repository")
            {
                return new PerfilRepository();
            }
            else
            {
                return null;
            }
        }
        public IGenericRelationship<Permiso, Perfil> GetPermisoPerfilRepository()
        {
            string backend = ConfigurationManager.AppSettings["backendSL"];
            if (backend == "SL.DAL.Repository")
            {
                return new Permiso_PerfilRepository();
            }
            else
            {
                return null;
            }
        }
        public IGenericRelationship<Perfil, Perfil> GetPerfilPerfilRepository()
        {
            string backend = ConfigurationManager.AppSettings["backendSL"];
            if (backend == "SL.DAL.Repository")
            {
                return new Perfil_PerfilRepository();
            }
            else
            {
                return null;
            }
        }
        public IGenericRelationship<Perfil, Usuario> GetUsuarioPerfilRepository()
        {
            string backend = ConfigurationManager.AppSettings["backendSL"];
            if (backend == "SL.DAL.Repository")
            {
                return new Usuario_PerfilRepository();
            }
            else
            {
                return null;
            }
        }
        public IGenericRelationship<Permiso, Usuario> GetUsuarioPermisoRepository()
        {
            string backend = ConfigurationManager.AppSettings["backendSL"];
            if (backend == "SL.DAL.Repository")
            {
                return new Usuario_PermisoRepository();
            }
            else
            {
                return null;
            }
        }

    }

}
