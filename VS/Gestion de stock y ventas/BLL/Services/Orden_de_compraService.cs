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
    public sealed class Orden_de_compraService : IGenericBusinessLogic<Orden_de_Compra>
    {
        #region Singleton
        private readonly static Orden_de_compraService _instance = new Orden_de_compraService();

            public static Orden_de_compraService Current
            {
                get
                {
                    return _instance;
                }
            }

            private Orden_de_compraService()
            {
                //Implent here the initialization of your singleton
            }
        #endregion 
        IOrden_de_CompraRepository<Orden_de_Compra> Orden_de_compraRepository = Factory.Current.GetOrden_de_CompraRepository();
        /// <summary>
        /// Eliminnar orden de compra
        /// </summary>
        /// <param name="obj">Orden de compra</param>
        public void delete(Orden_de_Compra obj)
        {
            try
            {
                Orden_de_compraRepository.delete(obj);
                Inventario inventario = new Inventario();
                inventario.materiaPrima = obj.materiaPrima;
                inventario.Cantidad = obj.Cantidad * -1;
                InventarioService.Current.update(inventario);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Obtener ordenes de compra
        /// </summary>
        /// <returns>Listado de ordenes de compra</returns>
        public IEnumerable<Orden_de_Compra> GetAll()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Obtener una orden de compra
        /// </summary>
        /// <param name="id">identificador de orden de compra</param>
        /// <returns>orden de compra obtenida</returns>
        public Orden_de_Compra GetOne(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Registrando ordenn de compra
        /// </summary>
        /// <param name="obj">orden de compra</param>
        public void insert(Orden_de_Compra obj)
        {
            try
            {
                Orden_de_compraRepository.insert(obj);
                Inventario inventario = new Inventario();
                inventario.materiaPrima = obj.materiaPrima;
                inventario.Cantidad = obj.Cantidad;
                InventarioService.Current.update(inventario);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Actualizando orden de compra
        /// </summary>
        /// <param name="obj">Orden de compra</param>
        public void update(Orden_de_Compra obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Listado ordenes de compra de una venta
        /// </summary>
        /// <param name="id">identificador de la venta</param>
        /// <returns>Listado de ordenes de compra de la venta con el parametro enviado anteriormente</returns>
        public IEnumerable<Orden_de_Compra> GetOrdenesDeCompra(int id)
        {
            List<Orden_de_Compra> orden_De_Compras = new List<Orden_de_Compra>();
            try
            {
                orden_De_Compras = (List<Orden_de_Compra>)Orden_de_compraRepository.GetOrdenesDeCompra(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return orden_De_Compras;
        }

        public Orden_de_Compra GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Orden_de_Compra GetOneDni(int Dni)
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
