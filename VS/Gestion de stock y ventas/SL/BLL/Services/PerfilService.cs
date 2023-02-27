using SL.BLL.Contracts;
using SL.DAL.Contracts;
using SL.DAL.Factories;
using SL.DOMAIN.SecurityComposite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.Services
{
    public class PerfilService : IGenericBusinessLogic<Perfil>
    {
        #region Singleton
        private readonly static PerfilService _instance = new PerfilService();

            public static PerfilService Current
            {
                get
                {
                    return _instance;
                }
            }

            private PerfilService()
            {
                //Implent here the initialization of your singleton
            }
        #endregion
        IGenericRepository<Perfil> perfilRepository = Factory.Current.GetPerfilRepository();
        IGenericRelationship<Permiso, Perfil> PermisoRelationship = Factory.Current.GetPermisoPerfilRepository();
        IGenericRelationship<Perfil, Perfil> PerfilRelationship = Factory.Current.GetPerfilPerfilRepository();

        /// <summary>
        /// Eliminando Perfil
        /// </summary>
        /// <param name="obj">Perfil</param>
        public void delete(Perfil obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Listando Perfil
        /// </summary>
        /// <returns>Listado de Perfiles</returns>
        public IEnumerable<Perfil> GetAll()
        {
            List<Perfil> perfils = new List<Perfil>();
            try
            {
                perfils = (List<Perfil>)perfilRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return perfils;
        }
        /// <summary>
        /// Obteniendo Perfil
        /// </summary>
        /// <param name="id">identicador de Perfil</param>
        /// <returns>Perfil</returns>
        public Perfil GetOne(int id)
        {
            Perfil perfil = new Perfil();
            try
            {
                perfil = perfilRepository.GetOne(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return perfil;
        }
        /// <summary>
        /// Registrando Perfil
        /// </summary>
        /// <param name="perfil">Perfil</param>
        public void insert(Perfil perfil)
        {
            Perfil perfilgetid = new Perfil();
            try
            {
                perfilRepository.Insert(perfil);
                perfilgetid = perfilRepository.GetId(perfil.Nombre);
                foreach (var item in perfil.ListadoPermisos)
                {
                    if(item.Cantidad_de_permisos > 0)
                    {
                        Perfil perfilJoin = new Perfil();
                        perfilJoin = (Perfil)item;
                        PerfilRelationship.Join(perfilgetid, perfilJoin);
                    }
                    if(item.Cantidad_de_permisos == 0)
                    {
                        Permiso permiso = new Permiso();
                        PermisoRelationship.Join(permiso, perfilgetid);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Actulizacion de Perfil
        /// </summary>
        /// <param name="perfil">Perfil</param>
        public void update(Perfil perfil)
        {
            try
            {
                PerfilRelationship.DeleteJoin(perfil);
                PermisoRelationship.DeleteJoin(perfil);
                perfilRepository.Update(perfil);
                foreach (var item in perfil.ListadoPermisos)
                {
                    if (item.Cantidad_de_permisos > 0)
                    {
                        Perfil perfilJoin = new Perfil();
                        perfilJoin = (Perfil)item;
                        PerfilRelationship.Join(perfil, perfilJoin);
                    }
                    if (item.Cantidad_de_permisos == 0)
                    {
                        Permiso permiso = new Permiso();
                        PermisoRelationship.Join(permiso, perfil);
                    }
                }

            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
    }
}
