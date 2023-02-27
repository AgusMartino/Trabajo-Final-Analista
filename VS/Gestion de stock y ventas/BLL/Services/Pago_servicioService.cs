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
    public sealed class Pago_servicioService : IGenericBusinessLogic<Pago_Servicio>
    {
        #region Singleton
        private readonly static Pago_servicioService _instance = new Pago_servicioService();

            public static Pago_servicioService Current
            {
                get
                {
                    return _instance;
                }
            }

            private Pago_servicioService()
            {
                //Implent here the initialization of your singleton
            }
        #endregion
        IPagosRepository<Pago_Servicio> Pago_servicioRepository = Factory.Current.GetPago_servicioRepository();
        /// <summary>
        /// eliminando pago de servicio
        /// </summary>
        /// <param name="obj">pago de servicio</param>
        public void delete(Pago_Servicio obj)
        {
            try
            {
                Pago_servicioRepository.delete(obj);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Listado de pago de servicio
        /// </summary>
        /// <returns>Listado de pago de servicio</returns>
        public IEnumerable<Pago_Servicio> GetAll()
        {
            List<Pago_Servicio> pago_Servicios = new List<Pago_Servicio>();
            try
            {
                pago_Servicios = (List<Pago_Servicio>)Pago_servicioRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Servicios;
        }
        /// <summary>
        /// Obteniendo Pago de servicio
        /// </summary>
        /// <param name="id">identificador de pago de servicio</param>
        /// <returns>pago de servicio obtenido</returns>
        public Pago_Servicio GetOne(int id)
        {
            Pago_Servicio pago_Servicio = new Pago_Servicio();
            try
            {
                pago_Servicio = Pago_servicioRepository.GetOne(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Servicio;
        }
        /// <summary>
        /// Registrando pago de servicio
        /// </summary>
        /// <param name="obj">pago de servicio</param>
        public void insert(Pago_Servicio obj)
        {
            try
            {
                Pago_servicioRepository.insert(obj);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Actualizando pago de servicio
        /// </summary>
        /// <param name="obj">pago de servicio</param>
        public void update(Pago_Servicio obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Listando pago de servicios entre fechas
        /// </summary>
        /// <param name="dateTimeInicio">fecha de inicio</param>
        /// <param name="dateTimeFin">Fecha de fin</param>
        /// <returns></returns>
        public IEnumerable<Pago_Servicio> GetPagoEntreFechas(DateTime dateTimeInicio, DateTime dateTimeFin)
        {
            List<Pago_Servicio> pago_Servicios = new List<Pago_Servicio>();
            try
            {
                pago_Servicios = (List<Pago_Servicio>)Pago_servicioRepository.GetPagoEntreFecha(dateTimeInicio, dateTimeFin);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Servicios;
        }

        public Pago_Servicio GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Pago_Servicio GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public bool ValidacionString(string code)
        {
            throw new NotImplementedException();
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
