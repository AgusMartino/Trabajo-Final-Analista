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
    public sealed class Unidad_de_medidaService : IGenericBusinessLogic<Unidad_De_Medida>
    {
        #region Singleton
        private readonly static Unidad_de_medidaService _instance = new Unidad_de_medidaService();

            public static Unidad_de_medidaService Current
            {
                get
                {
                    return _instance;
                }
            }

            private Unidad_de_medidaService()
            {
                //Implent here the initialization of your singleton
            }
        #endregion
        IGenericRepository<Unidad_De_Medida> UnidadDeMedidaRepository = Factory.Current.GetUnidadDeMedidaRepository();
        /// <summary>
        /// Eliminando Unidad de medida
        /// </summary>
        /// <param name="obj">Unidad de medida</param>
        public void delete(Unidad_De_Medida obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Listado de unidad de medida
        /// </summary>
        /// <returns>Listando de unidad de medida</returns>
        public IEnumerable<Unidad_De_Medida> GetAll()
        {
            List<Unidad_De_Medida> unidad_De_Medidas = new List<Unidad_De_Medida>();
            try
            {
                unidad_De_Medidas = (List<Unidad_De_Medida>)UnidadDeMedidaRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return unidad_De_Medidas;
        }
        /// <summary>
        /// Obteniendo Undiad de Medida
        /// </summary>
        /// <param name="id">identificador de unidad de medida</param>
        /// <returns></returns>
        public Unidad_De_Medida GetOne(int id)
        {
            Unidad_De_Medida unidad_De_Medida = new Unidad_De_Medida();
            try
            {
                unidad_De_Medida = UnidadDeMedidaRepository.GetOne(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return unidad_De_Medida;
        }
        /// <summary>
        /// Registrando Unidad de medida
        /// </summary>
        /// <param name="obj">Unidad de medida</param>
        public void insert(Unidad_De_Medida obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Actualizando Unidad de medida
        /// </summary>
        /// <param name="obj">Unidad de medida</param>
        public void update(Unidad_De_Medida obj)
        {
            throw new NotImplementedException();
        }

        public Unidad_De_Medida GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Unidad_De_Medida GetOneDni(int Dni)
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
