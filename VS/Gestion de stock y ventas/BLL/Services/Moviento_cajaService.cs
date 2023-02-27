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
    public sealed class Movimiento_cajaService : IGenericBusinessLogic<Movimiento_Caja>
    {
        #region Singleton
        private readonly static Movimiento_cajaService _instance = new Movimiento_cajaService();

        public static Movimiento_cajaService Current
        {
            get
            {
                return _instance;
            }
        }

        private Movimiento_cajaService()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
        IGenericRepository<Movimiento_Caja> movimiento_cajaRepository = Factory.Current.GetMovimiento_cajaRepository();
        /// <summary>
        /// Registrando Movimiento de caja
        /// </summary>
        /// <param name="movimiento_Caja">Moviemiento de caja</param>
        public void insert(Movimiento_Caja movimiento_Caja)
        {
            try
            {
                movimiento_Caja.cantidad = movimiento_Caja.cantidad * movimiento_Caja.tipo_De_Movimiento.Afecta_movimiento;
                movimiento_cajaRepository.insert(movimiento_Caja);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Elminando movimiento de caja
        /// </summary>
        /// <param name="movimiento_Caja">movimiento de caja</param>
        public void delete(Movimiento_Caja movimiento_Caja)
        {
            try
            {
                movimiento_cajaRepository.delete(movimiento_Caja);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Actualizando movimiento de caja
        /// </summary>
        /// <param name="movimiento_Caja">Movimiento de caja</param>
        public void update(Movimiento_Caja movimiento_Caja)
        {
            try
            {
                movimiento_cajaRepository.update(movimiento_Caja);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Obteniendo moviemiento de caja
        /// </summary>
        /// <param name="id">identificador de movimiento de caja</param>
        /// <returns>Movimiento de caja obtenido</returns>
        public Movimiento_Caja GetOne(int id)
        {
            Movimiento_Caja movimiento_Caja = new Movimiento_Caja();
            try
            {
                movimiento_Caja = movimiento_cajaRepository.GetOne(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return movimiento_Caja;
        }
        /// <summary>
        /// Listado de movimeintos de caja
        /// </summary>
        /// <returns>Lista de moviemientos de caja</returns>
        public IEnumerable<Movimiento_Caja> GetAll()
        {
            List<Movimiento_Caja> movimiento_Cajas = new List<Movimiento_Caja>();
            try
            {
                movimiento_Cajas = (List<Movimiento_Caja>)movimiento_cajaRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return movimiento_Cajas;
        }

        public Movimiento_Caja GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Movimiento_Caja GetOneDni(int Dni)
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
