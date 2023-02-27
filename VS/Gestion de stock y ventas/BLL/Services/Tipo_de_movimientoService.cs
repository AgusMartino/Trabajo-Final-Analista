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

    public sealed class Tipo_de_movimientoService : IGenericBusinessLogic<Tipo_de_movimiento>
    {
        #region Singleton
        private readonly static Tipo_de_movimientoService _instance = new Tipo_de_movimientoService();

        public static Tipo_de_movimientoService Current
        {
            get
            {
                return _instance;
            }
        }

        private Tipo_de_movimientoService()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
        IGenericRepository<Tipo_de_movimiento> Tipo_de_movimientoRepository = Factory.Current.GetTipo_de_movimientoRepository();
        /// <summary>
        /// Registrando tipo de movimiento
        /// </summary>
        /// <param name="tipo_De_Movimiento">tipo de movimiento</param>
        public void insert(Tipo_de_movimiento tipo_De_Movimiento)
        {
            try
            {
                Tipo_de_movimientoRepository.insert(tipo_De_Movimiento);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Eliminando tipo de movimiento
        /// </summary>
        /// <param name="tipo_De_Movimiento">tipo de movimiento</param>
        public void delete(Tipo_de_movimiento tipo_De_Movimiento)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Actualizando tipo de movimiento
        /// </summary>
        /// <param name="tipo_De_Movimiento">tipo de movimiento</param>
        public void update(Tipo_de_movimiento tipo_De_Movimiento)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Obteniendo tipo de movimiento
        /// </summary>
        /// <param name="id">identificador de tipo de movimiento</param>
        /// <returns></returns>
        public Tipo_de_movimiento GetOne(int id)
        {
            Tipo_de_movimiento tipo_De_Movimiento = new Tipo_de_movimiento();
            try
            {
                tipo_De_Movimiento = Tipo_de_movimientoRepository.GetOne(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return tipo_De_Movimiento;
        }
        /// <summary>
        /// Listando tipos de movimiento
        /// </summary>
        /// <returns>tipos de movimientos</returns>
        public IEnumerable<Tipo_de_movimiento> GetAll()
        {
            List<Tipo_de_movimiento> tipo_De_Movimientos = new List<Tipo_de_movimiento>();
            try
            {
                tipo_De_Movimientos = (List<Tipo_de_movimiento>)Tipo_de_movimientoRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return tipo_De_Movimientos;
        }

        public Tipo_de_movimiento GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Tipo_de_movimiento GetOneDni(int Dni)
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
