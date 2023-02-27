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
    public sealed class MateriaPrimaService : IGenericBusinessLogic<MateriaPrima>
    {
        #region Singleton
        private readonly static MateriaPrimaService _instance = new MateriaPrimaService();

        public static MateriaPrimaService Current
        {
            get
            {
                return _instance;
            }
        }

        private MateriaPrimaService()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
        IGenericRepository<MateriaPrima> materiaprimaRepository = Factory.Current.GetMateriaPrimaRepository();
        IGenericRepository<Inventario> InventarioRepository = Factory.Current.GetInventarioRepository();
        /// <summary>
        /// Registrando Materia Prima
        /// </summary>
        /// <param name="materiaPrima">Materia Prima</param>
        public void insert(MateriaPrima materiaPrima)
        {
            Inventario inventario = new Inventario();
            try
            {
                materiaprimaRepository.insert(materiaPrima);
                inventario.materiaPrima = materiaprimaRepository.GetOneCode(materiaPrima.Codigo);
                inventario.Cantidad = 0;
                InventarioRepository.insert(inventario);

            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Eliminando Materia Primma
        /// </summary>
        /// <param name="obj">Materia Prima</param>
        public void delete(MateriaPrima obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Actualizando Materia Prima
        /// </summary>
        /// <param name="obj">Materia Prima</param>
        public void update(MateriaPrima obj)
        {
            try
            {
                materiaprimaRepository.update(obj);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Obteniendo Materia Prima
        /// </summary>
        /// <param name="id">identificador de materia prima</param>
        /// <returns>Materia Prima obtenida</returns>
        public MateriaPrima GetOne(int id)
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            try
            {
                materiaPrima = materiaprimaRepository.GetOne(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return materiaPrima;
        }
        /// <summary>
        /// Listado de materia Primas
        /// </summary>
        /// <returns>Listado de Materias Primas</returns>
        public IEnumerable<MateriaPrima> GetAll()
        {
            List<MateriaPrima> materiaPrimas = new List<MateriaPrima>();
            try
            {
                materiaPrimas = (List<MateriaPrima>)materiaprimaRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return materiaPrimas;
        }

        public MateriaPrima GetOneCode(string code)
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            try
            {
                materiaPrima = materiaprimaRepository.GetOneCode(code);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return materiaPrima;
        }

        public MateriaPrima GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public bool ValidacionString(string code)
        {
            List<string> codes = new List<string>();
            bool validador = default;
            try
            {
                codes = (List<string>)materiaprimaRepository.ValidacionString();
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
