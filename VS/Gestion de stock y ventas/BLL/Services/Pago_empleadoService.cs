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
    public sealed class Pago_empleadoService : IGenericBusinessLogic<Pago_Empleado>
    {
        #region Singleton
        private readonly static Pago_empleadoService _instance = new Pago_empleadoService();

            public static Pago_empleadoService Current
            {
                get
                {
                    return _instance;
                }
            }

            private Pago_empleadoService()
            {
                //Implent here the initialization of your singleton
            }
        #endregion
        IPagosRepository<Pago_Empleado> Pago_empleadoRepository = Factory.Current.GetPago_empleadoRepository();
        /// <summary>
        /// Elminar pago de empleado
        /// </summary>
        /// <param name="obj">pago de empleado</param>
        public void delete(Pago_Empleado obj)
        {
            try
            {
                Pago_empleadoRepository.delete(obj);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Listado de pagos de empleados
        /// </summary>
        /// <returns>Listado de pago de empledos</returns>
        public IEnumerable<Pago_Empleado> GetAll()
        {
            List<Pago_Empleado> pago_Empleados = new List<Pago_Empleado>();
            try
            {
                pago_Empleados = (List<Pago_Empleado>)Pago_empleadoRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Empleados;
        }
        /// <summary>
        /// Obtener pago de empleado
        /// </summary>
        /// <param name="id">identificador de pago de empelado</param>
        /// <returns>pago de empleado</returns>
        public Pago_Empleado GetOne(int id)
        {
            Pago_Empleado pago_Empleado = new Pago_Empleado();
            try
            {
                pago_Empleado =  Pago_empleadoRepository.GetOne(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Empleado;
        }
        /// <summary>
        /// Registrar Pago de empleado
        /// </summary>
        /// <param name="obj">pago de empleado</param>
        public void insert(Pago_Empleado obj)
        {
            try
            {
                Pago_empleadoRepository.insert(obj);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Actualizacion de empleado
        /// </summary>
        /// <param name="obj">pago de empleado</param>
        public void update(Pago_Empleado obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Listado de pagos de empleados entre Fechas
        /// </summary>
        /// <param name="dateTimeInicio">Fecha de inicio</param>
        /// <param name="dateTimeFin">Fecha de fin</param>
        /// <returns>Listado de pago de empleados entre fechas</returns>
        public IEnumerable<Pago_Empleado> GetPagoEntreFechas(DateTime dateTimeInicio, DateTime dateTimeFin)
        {
            List<Pago_Empleado> pago_Empleados = new List<Pago_Empleado>();
            try
            {
                pago_Empleados = (List<Pago_Empleado>)Pago_empleadoRepository.GetPagoEntreFecha(dateTimeInicio, dateTimeFin);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Empleados;
        }

        public Pago_Empleado GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Pago_Empleado GetOneDni(int Dni)
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
