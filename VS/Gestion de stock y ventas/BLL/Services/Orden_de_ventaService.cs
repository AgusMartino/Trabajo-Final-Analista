using BLL.Contracts;
using DLL.Contracts;
using DLL.Factories;
using DOMAIN;
using DOMAIN.Productos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public sealed class Orden_de_ventaService : IGenericBusinessLogic<Orden_de_Venta>
    {
        #region Singleton
        private readonly static Orden_de_ventaService _instance = new Orden_de_ventaService();

            public static Orden_de_ventaService Current
            {
                get
                {
                    return _instance;
                }
            }

            private Orden_de_ventaService()
            {
                //Implent here the initialization of your singleton
            }
        #endregion
        IOrden_de_ventaRepository<Orden_de_Venta> Orden_de_ventaRepository = Factory.Current.GetOrden_de_VentaRepository();
        /// <summary>
        /// Elimianando orden de venta
        /// </summary>
        /// <param name="orden_De_Venta">orden de venta</param>
        public void delete(Orden_de_Venta orden_De_Venta)
        {
            try
            {
                Orden_de_ventaRepository.delete(orden_De_Venta);
                List<MateriaPrima> materiaPrimas = new List<MateriaPrima>();
                materiaPrimas = ProductoService.Current.GetMateriaPrimas(orden_De_Venta.producto);
                foreach (var item in materiaPrimas)
                {
                    item.Cantidad = item.Cantidad * orden_De_Venta.Cantidad;
                    Inventario inventario = new Inventario();
                    inventario.Cantidad = item.Cantidad;
                    inventario.materiaPrima = item;
                    InventarioService.Current.update(inventario);
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Listado de ordenes de vennta
        /// </summary>
        /// <returns>Listado de ordenes de venta</returns>
        public IEnumerable<Orden_de_Venta> GetAll()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// obteniendo orden de veennta
        /// </summary>
        /// <param name="id">identificador de orden de venta</param>
        /// <returns>orden de venta obtenida</returns>
        public Orden_de_Venta GetOne(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Registrando orden de venta 
        /// </summary>
        /// <param name="orden_De_Venta">orden de venta</param>
        public void insert(Orden_de_Venta orden_De_Venta)
        {
            try
            {
                Orden_de_ventaRepository.insert(orden_De_Venta);
                List<MateriaPrima> materiaPrimas = new List<MateriaPrima>();
                materiaPrimas = ProductoService.Current.GetMateriaPrimas(orden_De_Venta.producto);
                foreach (var item in materiaPrimas)
                {
                    item.Cantidad = (item.Cantidad * orden_De_Venta.Cantidad) * -1;
                    Inventario inventario = new Inventario();
                    inventario.Cantidad = item.Cantidad;
                    inventario.materiaPrima = item;
                    InventarioService.Current.update(inventario);
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Eliminando orden de venta
        /// </summary>
        /// <param name="obj">orden de venta</param>
        public void update(Orden_de_Venta obj)
        {
            try
            {
                Orden_de_ventaRepository.delete(obj);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// listado de ordenes de venta
        /// </summary>
        /// <param name="id">identificado de la venta</param>
        /// <returns>Ordenes de venta de la venta con el identificador pasado como parametro</returns>
        public IEnumerable<Orden_de_Venta> GetOrdenes(int id)
        {
            List<Orden_de_Venta> orden_De_Ventas = new List<Orden_de_Venta>();
            try
            {
                orden_De_Ventas = (List<Orden_de_Venta>)Orden_de_ventaRepository.GetOrdenes(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return orden_De_Ventas;
        }

        public Orden_de_Venta GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Orden_de_Venta GetOneDni(int Dni)
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
