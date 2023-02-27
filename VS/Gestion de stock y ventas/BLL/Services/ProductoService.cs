 using BLL.Contracts;
using DLL.Contracts;
using DLL.Factories;
using DOMAIN.Productos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public sealed class ProductoService : IGenericBusinessLogic<Producto>
    {
        #region Singleton
        private readonly static ProductoService _instance = new ProductoService();

        public static ProductoService Current
        {
            get
            {
                return _instance;
            }
        }

        private ProductoService()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
        IGenericRepository<Producto> ProductoRepository = Factory.Current.GetProductoRepository();
        IGenericRelationship<MateriaPrima, Producto> genericRelationship = Factory.Current.GetMateriaPrimaProductoRelationship();
        /// <summary>
        /// Registrar Producto
        /// </summary>
        /// <param name="producto">producto</param>
        public void insert(Producto producto)
        {
            Producto productoGetOne = default;
            try
            {
                //Alta de producto
                try
                {
                    ProductoRepository.insert(producto);
                }
                catch (Exception ex)
                {
                    SL.Services.ExceptionManager.Current.Handle(this, ex);
                }

                //Obtener Producto Creado
                try
                {
                    productoGetOne = ProductoRepository.GetOneCode(producto.CodigoProducto);
                    producto.IdProducto = productoGetOne.IdProducto;
                }
                catch (Exception ex)
                {
                    SL.Services.ExceptionManager.Current.Handle(this, ex);
                }
                //LLenar tabla de relacion de MateriaPrima_Producto
                try
                {
                    for (int C = 0; C <= producto.CantidadDeComponentes - 1; C++)
                    {
                        MateriaPrima item = (MateriaPrima)producto.Componentes[C];
                        genericRelationship.Join(item, producto);
                    }
                }
                catch (Exception ex)
                {
                    SL.Services.ExceptionManager.Current.Handle(this, ex);
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Eliminar producto
        /// </summary>
        /// <param name="obj">producto</param>
        public void delete(Producto obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Actualizar producto
        /// </summary>
        /// <param name="producto">producto</param>
        public void update(Producto producto)
        {
            try
            {
                //update de producto
                try
                {
                    ProductoRepository.update(producto);
                }
                catch (Exception ex)
                {
                    SL.Services.ExceptionManager.Current.Handle(this, ex);
                }

                //Eliminar Relaciones en la tabla de MateriaPrima_Producto
                try
                {
                    genericRelationship.DeleteJoin(producto);
                }
                catch (Exception ex)
                {
                    SL.Services.ExceptionManager.Current.Handle(this, ex);
                }
                //LLenar tabla de relacion de MateriaPrima_Producto
                try
                {
                    for (int C = 0; C <= producto.CantidadDeComponentes - 1; C++)
                    {
                        MateriaPrima item = (MateriaPrima)producto.Componentes[C];
                        genericRelationship.Join(item, producto);
                    }
                }
                catch (Exception ex)
                {
                    SL.Services.ExceptionManager.Current.Handle(this, ex);
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Obteniendo producto
        /// </summary>
        /// <param name="id">identificador del producto</param>
        /// <returns>producto obtenido</returns>
        public Producto GetOne(int id)
        {
            Producto producto = new Producto();
            try
            {
                producto = ProductoRepository.GetOne(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return producto;
        }
        /// <summary>
        /// Listado de productos
        /// </summary>
        /// <returns>listado de productos</returns>
        public IEnumerable<Producto> GetAll()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                productos = (List<Producto>)ProductoRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return productos;
        }
        /// <summary>
        /// Obteniendo Componente del prodcuto
        /// </summary>
        /// <param name="producto">prodcuto</param>
        /// <returns>listado de componentes del producto</returns>
        public List<MateriaPrima> GetMateriaPrimas(Producto producto)
        {
            List<MateriaPrima> materiaPrimas = new List<MateriaPrima>();
            try
            {
                materiaPrimas = genericRelationship.GetComponentes(producto);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return materiaPrimas;
        }

        public Producto GetOneCode(string code)
        {
            Producto producto = new Producto();
            try
            {
                producto = ProductoRepository.GetOneCode(code);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return producto;
        }

        public Producto GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public bool ValidacionString(string code)
        {
            List<string> codes = new List<string>();
            bool validador = default;
            try
            {
                codes = (List<string>)ProductoRepository.ValidacionString();
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
