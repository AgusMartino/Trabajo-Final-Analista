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
    public sealed class EmpleadoService : IGenericBusinessLogic<Empleado>
    {
        #region Singleton
        private readonly static EmpleadoService _instance = new EmpleadoService();

            public static EmpleadoService Current
            {
                get
                {
                    return _instance;
                }
            }

            private EmpleadoService()
            {
                //Implent here the initialization of your singleton
            }
        #endregion
        IGenericRepository<Empleado> EmpleadoRepository = Factory.Current.GetEmpleadoRepository();
        /// <summary>
        /// Empleado a eliminar
        /// </summary>
        /// <param name="obj">Empleado</param>
        public void delete(Empleado obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Listado de empleado
        /// </summary>
        /// <returns>Listado de empleados registrados</returns>
        public IEnumerable<Empleado> GetAll()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                empleados = (List<Empleado>)EmpleadoRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return empleados;
        }
        /// <summary>
        /// Obteniendo un empleado
        /// </summary>
        /// <param name="id">identificador del empleado</param>
        /// <returns>Empleado obtenido</returns>
        public Empleado GetOne(int id)
        {
            Empleado empleado = default;
            try
            {
                empleado = EmpleadoRepository.GetOne(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return empleado;
        }
        /// <summary>
        /// Registrando empleado
        /// </summary>
        /// <param name="obj">Empelado</param>
        public void insert(Empleado obj)
        {
            try
            {
                EmpleadoRepository.insert(obj);
            }
            catch (Exception ex)
            {

                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Actualizando Empleado
        /// </summary>
        /// <param name="obj">Empleado</param>
        public void update(Empleado obj)
        {
            try
            {
                EmpleadoRepository.update(obj);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public Empleado GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Empleado GetOneDni(int Dni)
        {
            Empleado empleado = default;
            try
            {
                empleado = EmpleadoRepository.GetOneDni(Dni);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return empleado;
        }

        public bool ValidacionString(string code)
        {
            throw new NotImplementedException();
        }

        public bool ValidacionInt(int Dni)
        {
            List<int> Dnis = new List<int>();
            bool validador = default;
            try
            {
                Dnis = (List<int>)EmpleadoRepository.ValidacionInt();
                if (Dnis.Contains(Dni))
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

        public void importMassive(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}
