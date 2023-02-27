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
    public sealed class RubroService : IGenericBusinessLogic<Rubro>
    {
        #region Singleton
        private readonly static RubroService _instance = new RubroService();

            public static RubroService Current
            {
                get
                {
                    return _instance;
                }
            }

            private RubroService()
            {
                //Implent here the initialization of your singleton
            }
        #endregion
        IGenericRepository<Rubro> RubroRepository = Factory.Current.GetRubroRepository();
        /// <summary>
        /// Eliminando Rubro
        /// </summary>
        /// <param name="obj">rubro</param>
        public void delete(Rubro obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Listando rubros
        /// </summary>
        /// <returns>Listado de ribros registrados</returns>
        public IEnumerable<Rubro> GetAll()
        {
            List<Rubro> rubros = new List<Rubro>();
            try
            {
                rubros = (List<Rubro>)RubroRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return rubros;
        }
        /// <summary>
        /// Obteniendo rubro
        /// </summary>
        /// <param name="id">identificador de rubro</param>
        /// <returns>Rubro obtenido</returns>
        public Rubro GetOne(int id)
        {
            Rubro rubro = default;
            try
            {
                rubro = RubroRepository.GetOne(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return rubro;
        }
        /// <summary>
        /// Registrando rubro
        /// </summary>
        /// <param name="obj">Rubro</param>
        public void insert(Rubro obj)
        {
            try
            {
                RubroRepository.insert(obj);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Actualizando Rubro
        /// </summary>
        /// <param name="obj">rubro</param>
        public void update(Rubro obj)
        {
            try
            {
                RubroRepository.update(obj);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public Rubro GetOneCode(string code)
        {
            Rubro rubro = default;
            try
            {
                rubro = RubroRepository.GetOneCode(code);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return rubro;
        }

        public Rubro GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public bool ValidacionString(string code)
        {
            List<string> codes = new List<string>();
            bool validador = default;
            try
            {
                codes = (List<string>)RubroRepository.ValidacionString();
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
