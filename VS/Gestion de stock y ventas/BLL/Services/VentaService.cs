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
    public sealed class VentaService : IGenericBusinessLogic<Venta>
    {
        #region Singleton
        private readonly static VentaService _instance = new VentaService();

            public static VentaService Current
            {
                get
                {
                    return _instance;
                }
            }

            private VentaService()
            {
                //Implent here the initialization of your singleton
            }
        #endregion
        IVentaRepository<Venta> VentaRepository = Factory.Current.GetVentaRepository();
        IOrden_de_ventaRepository<Orden_de_Venta> Orden_de_VentaRepository = Factory.Current.GetOrden_de_VentaRepository();
        /// <summary>
        /// Elminanado Venta
        /// </summary>
        /// <param name="obj">Venta</param>
        public void delete(Venta obj)
        {
            try
            {
                //Cancelando Ordenes de Venta
                foreach (var item in obj.Orden_De_Ventas)
                {
                    Orden_de_ventaService.Current.delete(item);
                }
                //Cancelando Venta
                VentaRepository.delete(obj);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Listando Ventas registradas
        /// </summary>
        /// <returns>Listado de venntas regsitradas</returns>
        public IEnumerable<Venta> GetAll()
        {
            List<Venta> ventas = new List<Venta>();
            try
            {
                ventas = (List<Venta>)VentaRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return ventas;
        }
        /// <summary>
        /// Obteniendo Venta
        /// </summary>
        /// <param name="id">identificador de venta</param>
        /// <returns>Venta Obtenida</returns>
        public Venta GetOne(int id)
        {
            Venta venta = new Venta();
            try
            {
                venta = VentaRepository.GetOne(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return venta;
        }
        /// <summary>
        /// Registrando Venta
        /// </summary>
        /// <param name="obj">Venta</param>
        public void insert(Venta obj)
        {
            Venta venta = new Venta();
            try
            {
                //Ingresando venta
                VentaRepository.insert(obj);
                //Obteniendo ID
                venta = GetId(obj);
                //Insertando Orden de venta
                for (int i = 0; i <= obj.Orden_De_Ventas.Count - 1; i++)
                {
                    obj.Orden_De_Ventas[i].venta = venta;
                    Orden_de_VentaRepository.insert(obj.Orden_De_Ventas[i]);
                }

            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Actualizando Venta
        /// </summary>
        /// <param name="obj">Venta</param>
        public void update(Venta obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Obteniendo Identififcador de la venta
        /// </summary>
        /// <param name="venta">Venta</param>
        /// <returns></returns>
        public Venta GetId(Venta venta)
        {
            Venta ventaGet = new Venta();
            try
            {
                ventaGet = VentaRepository.GetId(venta.Fecha_de_Venta);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return ventaGet;
        }
        /// <summary>
        /// Obteniendo Listado de ventas entre fechas
        /// </summary>
        /// <param name="dateTimeInicio">Fechas de inicio</param>
        /// <param name="dateTimeFin">Fecha de fin</param>
        /// <returns>Listado de ventas entre fechas</returns>
        public IEnumerable<Venta> GetVentasEntreFechas(DateTime dateTimeInicio, DateTime dateTimeFin)
        {
            List<Venta> ventas = new List<Venta>();
            try
            {
                ventas = (List<Venta>)VentaRepository.GetVentasEntreFechas(dateTimeInicio, dateTimeFin);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return ventas;
        }

        public Venta GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Venta GetOneDni(int Dni)
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
