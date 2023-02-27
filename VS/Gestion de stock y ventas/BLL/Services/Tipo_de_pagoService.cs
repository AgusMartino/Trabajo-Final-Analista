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
    public sealed class Tipo_de_pagoService : IGenericBusinessLogic<Tipo_de_pago>
    {
        #region Singleton
        private readonly static Tipo_de_pagoService _instance = new Tipo_de_pagoService();

            public static Tipo_de_pagoService Current
            {
                get
                {
                    return _instance;
                }
            }

            private Tipo_de_pagoService()
            {
                //Implent here the initialization of your singleton
            }
        #endregion
        IGenericRepository<Tipo_de_pago> Tipo_de_pagoRepository = Factory.Current.GetTipo_de_PagoRepository();
        /// <summary>
        /// Eliminando Tipo de pago
        /// </summary>
        /// <param name="obj">tipo de pago</param>
        public void delete(Tipo_de_pago obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Listando tipo de pago
        /// </summary>
        /// <returns>Listado de tipos de pago</returns>
        public IEnumerable<Tipo_de_pago> GetAll()
        {
            List<Tipo_de_pago> tipo_De_Pagos = new List<Tipo_de_pago>();
            try
            {
                tipo_De_Pagos = (List<Tipo_de_pago>)Tipo_de_pagoRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return tipo_De_Pagos;
        }
        /// <summary>
        /// Obteniendo Tipo de pago
        /// </summary>
        /// <param name="id">identificador de tipo de pago</param>
        /// <returns>tipo de pago obtenido</returns>
        public Tipo_de_pago GetOne(int id)
        {
            Tipo_de_pago tipo_De_Pago = new Tipo_de_pago();
            try
            {
                tipo_De_Pago = Tipo_de_pagoRepository.GetOne(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return tipo_De_Pago;
        }
        /// <summary>
        /// Registrando tipo de pago
        /// </summary>
        /// <param name="obj">tipo de pago</param>
        public void insert(Tipo_de_pago obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Actualizando tipo de pago
        /// </summary>
        /// <param name="obj">tipo de pago</param>
        public void update(Tipo_de_pago obj)
        {
            throw new NotImplementedException();
        }

        public Tipo_de_pago GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Tipo_de_pago GetOneDni(int Dni)
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
