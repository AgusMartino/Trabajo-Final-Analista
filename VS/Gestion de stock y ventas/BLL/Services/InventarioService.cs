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
    public sealed class InventarioService : IGenericBusinessLogic<Inventario>
    {
        #region Singleton
        private readonly static InventarioService _instance = new InventarioService();

        public static InventarioService Current
        {
            get
            {
                return _instance;
            }
        }

        private InventarioService()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
        IGenericRepository<Inventario> inventarioRepository = Factory.Current.GetInventarioRepository();
        /// <summary>
        /// Registrando inventario
        /// </summary>
        /// <param name="inventario">inventario</param>
        public void insert(Inventario inventario)
        {
            try
            {
                inventarioRepository.insert(inventario);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Eliminando inventario
        /// </summary>
        /// <param name="inventario">inventario</param>
        public void delete(Inventario inventario)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Actualizando inventario
        /// </summary>
        /// <param name="inventario">inventario</param>
        public void update(Inventario inventario)
        {
            Inventario inventarioGet = new Inventario();
            try
            {
                inventarioGet = inventarioRepository.GetOne((int)inventario.materiaPrima.IdMateriaPrima);
                inventarioGet.Cantidad = inventario.Cantidad + inventarioGet.Cantidad;
                inventarioRepository.update(inventarioGet);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Obteniendo inventario
        /// </summary>
        /// <param name="id">identificador de inventario</param>
        /// <returns>Inventario obtenido</returns>
        public Inventario GetOne(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Listado de inventario
        /// </summary>
        /// <returns>Lista de inventario registrados</returns>
        public IEnumerable<Inventario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Inventario GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Inventario GetOneDni(int Dni)
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
