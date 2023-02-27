using BLL.Contracts;
using DLL.Contracts;
using DLL.Factories;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public sealed class ServicioService : IGenericBusinessLogic<Servicio>
    {
        #region Singleton
        private readonly static ServicioService _instance = new ServicioService();

            public static ServicioService Current
            {
                get
                {
                    return _instance;
                }
            }

            private ServicioService()
            {
                //Implent here the initialization of your singleton
            }
        #endregion
        IGenericRepository<Servicio> ServicioRepository = Factory.Current.GetServicioRepository();
        /// <summary>
        /// Eliminando servicio
        /// </summary>
        /// <param name="obj"></param>
        public void delete(Servicio obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Listando de servicio
        /// </summary>
        /// <returns>Lista de servicios</returns>
        public IEnumerable<Servicio> GetAll()
        {
            List<Servicio> servicios = new List<Servicio>();
            try
            {
                servicios = (List<Servicio>)ServicioRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return servicios;
        }
        /// <summary>
        /// Obteniendo servicio
        /// </summary>
        /// <param name="code">identificador de servicio</param>
        /// <returns>servicio obtenido</returns>
        public Servicio GetOneCode(string code)
        {
            Servicio servicio = default;
            try
            {
                servicio = ServicioRepository.GetOneCode(code);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return servicio;
        }
        /// <summary>
        /// registrando servicio
        /// </summary>
        /// <param name="obj">servicio</param>
        public void insert(Servicio obj)
        {
            try
            {
                ServicioRepository.insert(obj);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Actualizando serivicio
        /// </summary>
        /// <param name="obj">servicio</param>
        public void update(Servicio obj)
        {
            try
            {
                ServicioRepository.update(obj);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Obteniendo servicio
        /// </summary>
        /// <param name="id">id de servicio</param>
        /// <returns>Servicio</returns>
        public Servicio GetOne(int id)
        {
            Servicio servicio = default;
            try
            {
                servicio = ServicioRepository.GetOne(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return servicio;
        }

        public Servicio GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public bool ValidacionString(string code)
        {
            List<string> codes = new List<string>();
            bool validador = default;
            try
            {
                codes = (List<string>)ServicioRepository.ValidacionString();
                if (codes.Contains(code))
                {
                    validador = true;
                }
                else
                {
                    validador = false;
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return validador;
        }

        public bool ValidacionInt(int Dni)
        {
            throw new NotImplementedException();
        }

        public void importMassive(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}
