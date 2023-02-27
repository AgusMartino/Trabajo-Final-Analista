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
    public sealed class ProveedorService : IGenericBusinessLogic<Proveedor>
    {
        #region Singleton
        private readonly static ProveedorService _instance = new ProveedorService();

            public static ProveedorService Current
            {
                get
                {
                    return _instance;
                }
            }

            private ProveedorService()
            {
                //Implent here the initialization of your singleton
            }
        #endregion
        IGenericRepository<Proveedor> ProveedorRepository = Factory.Current.GetProveedorRepository();
        /// <summary>
        /// Eliminando proveedor
        /// </summary>
        /// <param name="obj">proveedor</param>
        public void delete(Proveedor obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Listado de proveedores 
        /// </summary>
        /// <returns>listado de proveedores registrados</returns>
        public IEnumerable<Proveedor> GetAll()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            try
            {
                proveedores = (List<Proveedor>)ProveedorRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return proveedores;
        }
        /// <summary>
        /// Obteniendo proveedor
        /// </summary>
        /// <param name="id">identificador de proveedor</param>
        /// <returns>Proveedor obtenido</returns>
        public Proveedor GetOne(int id)
        {
            Proveedor proveedor = default;
            try
            {
                proveedor = ProveedorRepository.GetOne(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return proveedor;
        }
        /// <summary>
        /// Retgistrando Proveedor
        /// </summary>
        /// <param name="obj">proveedor</param>
        public void insert(Proveedor obj)
        {
            try
            {
                ProveedorRepository.insert(obj);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Actualizando Proveedor
        /// </summary>
        /// <param name="obj">proveedor</param>
        public void update(Proveedor obj)
        {
            try
            {
                ProveedorRepository.update(obj);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public Proveedor GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Proveedor GetOneDni(int Cuit)
        {
            Proveedor proveedor = default;
            try
            {
                proveedor = ProveedorRepository.GetOneDni(Cuit);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return proveedor;
        }

        public bool ValidacionString(string code)
        {
            throw new NotImplementedException();
        }

        public bool ValidacionInt(int cuit)
        {
            List<int> cuits = new List<int>();
            bool validador = default;
            try
            {
                cuits = (List<int>)ProveedorRepository.ValidacionInt();
                if (cuits.Contains(cuit))
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
