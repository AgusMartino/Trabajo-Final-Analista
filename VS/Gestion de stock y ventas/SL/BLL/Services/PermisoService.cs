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
    public class PermisoService : IGenericBusinessLogic<Permiso>
    {
        #region Singleton
        private readonly static PermisoService _instance = new PermisoService();

            public static PermisoService Current
            {
                get
                {
                    return _instance;
                }
            }

            private PermisoService()
            {
                //Implent here the initialization of your singleton
            }
        #endregion
        IGenericRepository<Permiso> permisoRepository = Factory.Current.GetPermisoRepository();
        /// <summary>
        /// Eliminando Permiso
        /// </summary>
        /// <param name="obj">permiso</param>
        public void delete(Permiso obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Listando Permisos
        /// </summary>
        /// <returns>Listando permisos</returns>
        public IEnumerable<Permiso> GetAll()
        {
            List<Permiso> permisos = new List<Permiso>();
            try
            {
                permisos = (List<Permiso>)permisoRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return permisos;
        }
        public Permiso GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void insert(Permiso obj)
        {
            throw new NotImplementedException();
        }

        public void update(Permiso obj)
        {
            throw new NotImplementedException();
        }
    }
}
