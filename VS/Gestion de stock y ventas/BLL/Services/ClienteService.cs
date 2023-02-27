using BLL.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.Contracts;
using DLL.Factories;
using System.Data;

namespace BLL.Services
{
    public sealed class ClienteService : IGenericBusinessLogic<Cliente>
    {
        #region Singleton
        private readonly static ClienteService _instance = new ClienteService();

            public static ClienteService Current
            {
                get
                {
                    return _instance;
                }
            }

            private ClienteService()
            {
                //Implent here the initialization of your singleton
            }
        #endregion
        IGenericRepository<Cliente> ClienteRepository = Factory.Current.GetClienteRepository();

        /// <summary>
        /// Cliente a eliminar
        /// </summary>
        /// <param name="obj">Cliente a eliminar</param>
        public void delete(Cliente obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Listado de clientes
        /// </summary>
        /// <returns>Listado de clientes completo</returns>
        public IEnumerable<Cliente> GetAll()
        {
            
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                 clientes = (List<Cliente>)ClienteRepository.GetAll();
            }
            catch(Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return clientes;
        }
        /// <summary>
        /// Obtiene un cliente mediate el parametro enviado
        /// </summary>
        /// <param name="id">Identificador del cliente</param>
        /// <returns>Cliente obtenido</returns>
        public Cliente GetOne(int id)
        {
            Cliente cliente = new Cliente();
            try
            {
                cliente = ClienteRepository.GetOne(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return cliente;
        }
        /// <summary>
        /// Registrando cliente
        /// </summary>
        /// <param name="obj">Cliennte a registrar</param>
        public void insert(Cliente obj)
        {
            try
            {
                ClienteRepository.insert(obj);
            }
            catch(Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Actuializar cliente
        /// </summary>
        /// <param name="obj">Cliente a actualizar</param>
        public void update(Cliente obj)
        {
            try
            {
                ClienteRepository.update(obj);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex); 
            }
        }

        public Cliente GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Cliente GetOneDni(int Dni)
        {
            Cliente cliente = new Cliente();
            try
            {
                cliente = ClienteRepository.GetOneDni(Dni);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return cliente;
        }

        public bool ValidacionString(string code)
        {
            throw new NotImplementedException();
        }

        public bool ValidacionInt(int Dni)
        {
            List<int> Dnis = new List<int>();
            bool validador = default;
            try
            {
                Dnis = (List<int>)ClienteRepository.ValidacionInt();
                if (Dnis.Contains(Dni))
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
