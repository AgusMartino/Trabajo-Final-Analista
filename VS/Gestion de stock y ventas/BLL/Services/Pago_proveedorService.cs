
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
    public sealed class Pago_proveedorService : IGenericBusinessLogic<Pago_Proveedor>
    {
        #region Singleton
        private readonly static Pago_proveedorService _instance = new Pago_proveedorService();

            public static Pago_proveedorService Current
            {
                get
                {
                    return _instance;
                }
            }

            private Pago_proveedorService()
            {
                //Implent here the initialization of your singleton
            }
        #endregion
        IPagoProveedorRepository<Pago_Proveedor> Pago_ProveedorRepository = Factory.Current.GetPago_proveedorRepository();
        IOrden_de_CompraRepository<Orden_de_Compra> Orden_de_CompraRepository = Factory.Current.GetOrden_de_CompraRepository();
        /// <summary>
        /// Elminar pago de proveedor
        /// </summary>
        /// <param name="obj">pago de proveedor</param>
        public void delete(Pago_Proveedor obj)
        {
            try
            {
                //Cancelando Ordenes de compra del Pago de proveedor
                foreach (var item in obj.Orden_De_Compras)
                {
                    Orden_de_compraService.Current.delete(item);
                }
                //Cancelando Pago de proveedor
                Pago_ProveedorRepository.delete(obj);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Obteniedo listado de pago de proveedores
        /// </summary>
        /// <returns>Listado de pago de proveedores</returns>
        public IEnumerable<Pago_Proveedor> GetAll()
        {
            List<Pago_Proveedor> pago_Proveedors = new List<Pago_Proveedor>();
            try
            {
                pago_Proveedors = (List<Pago_Proveedor>)Pago_ProveedorRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Proveedors;
        }
        /// <summary>
        /// Obteniendo pago de proveedor
        /// </summary>
        /// <param name="id">identificador de pago de proveedor</param>
        /// <returns>Pago de proveedor obtenido</returns>
        public Pago_Proveedor GetOne(int id)
        {
            Pago_Proveedor pago_Proveedor = new Pago_Proveedor();
            try
            {
                pago_Proveedor = Pago_ProveedorRepository.GetOne(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Proveedor;
        }
        /// <summary>
        /// Registrando pago de proveedor
        /// </summary>
        /// <param name="obj">Pago de proveedor</param>
        public void insert(Pago_Proveedor obj)
        {
            Pago_Proveedor pago_Proveedor = new Pago_Proveedor();
            try
            {
                Pago_ProveedorRepository.insert(obj);
                pago_Proveedor = GetId(obj);
                for(int i = 0; i <= obj.Orden_De_Compras.Count -1; i++)
                {
                    obj.Orden_De_Compras[i].Pago_Proveedor = pago_Proveedor;
                    Orden_de_CompraRepository.insert(obj.Orden_De_Compras[i]);
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Actualizando Pago de proveedor
        /// </summary>
        /// <param name="obj">pago de proveedor</param>
        public void update(Pago_Proveedor obj)
        {
            try
            {
                Pago_ProveedorRepository.update(obj);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// obteniendo monto adeudado del proveedor
        /// </summary>
        /// <param name="proveedor">proveedor</param>
        /// <returns>ultimo pago al proveedor</returns>
        public Pago_Proveedor GetMontoAdeudado(Proveedor proveedor)
        {
            Pago_Proveedor pago_Proveedor = new Pago_Proveedor();
            try
            {
                pago_Proveedor = Pago_ProveedorRepository.GetMontoAdeudado((int)proveedor.Cuit);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Proveedor;
        }
        /// <summary>
        /// Obteniendo identificador de pago de proveedor
        /// </summary>
        /// <param name="pago_Proveedor">pago de proveedor</param>
        /// <returns>pago de proveedor obtenido</returns>
        public Pago_Proveedor GetId(Pago_Proveedor pago_Proveedor)
        {
            Pago_Proveedor pago_proveedor = new Pago_Proveedor();
            try
            {
                pago_proveedor = Pago_ProveedorRepository.GetPago_proveedorId(pago_Proveedor.Fecha_Pago);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_proveedor;
        }
        /// <summary>
        /// Listando pago de proveedor entre fechas 
        /// </summary>
        /// <param name="dateTimeInicio">Fecha de inicio</param>
        /// <param name="dateTimeFin">Fecha de fin</param>
        /// <returns>Listado de pago de proveedor entre fechas</returns>
        public IEnumerable<Pago_Proveedor> GetPagoEntreFechas(DateTime dateTimeInicio, DateTime dateTimeFin)
        {
            List<Pago_Proveedor> pago_Proveedors = new List<Pago_Proveedor>();
            try
            {
                pago_Proveedors = (List<Pago_Proveedor>)Pago_ProveedorRepository.GetPagosEntreFecha(dateTimeInicio, dateTimeFin);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Proveedors;
        }

        public Pago_Proveedor GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Pago_Proveedor GetOneDni(int Dni)
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
