using DLL.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Tracing;
using DAL.Tools;
using System.Data.SqlClient;
using DLL.Repositories.SqlServer.Adapters;
using System.Data;

namespace DLL.Repositories.SqlServer
{
    internal class ClienteRepository : IGenericRepository<Cliente>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Cliente] (Nombre, Apellido, Fecha_de_nacimiento, Dni, Direccion) VALUES (@Nombre, @Apellido, @Fecha_de_nacimiento, @Dni, @Direccion)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Cliente] SET Nombre = @Nombre, Apellido = @Apellido, Fecha_de_nacimiento = @Fecha_nacimiento, Direccion = @Direccion WHERE  Dni = @Dni";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Cliente] WHERE Dni = @Dni";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Cliente] WHERE Dni = @Dni";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Cliente]";
        }
        #endregion

        public void delete(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> GetAll()
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente cliente = default;
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Lista de Clientes", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        if(values[3] == DBNull.Value)
                        {
                            values[3] = null;
                        }
                        cliente = ClienteAdapter.Current.Adapt(values);
                        clientes.Add(cliente);
                    }
                }
            }
            catch(Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }

            return clientes;
        }

        public Cliente GetOne(int id)
        {
            Cliente cliente = default;
            string statement = "SELECT * FROM [dbo].[Cliente] WHERE IdCliente = @IdCliente";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo el cliente con id {id}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text,
                                new SqlParameter("@IdCliente", id)))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        if (values[3] == DBNull.Value)
                        {
                            values[3] = null;
                        }
                        cliente = ClienteAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return cliente;
        }

        public Cliente GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Cliente GetOneDni(int Dni)
        {
            Cliente cliente = default;
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo el cliente con dni {Dni}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                                new SqlParameter("@Dni", Dni)))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        if (values[3] == DBNull.Value)
                        {
                            values[3] = null;
                        }
                        cliente = ClienteAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return cliente;
        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Cliente cliente)
        { 
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Haciendo el Alta del cliente Dni {cliente.Dni}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@Nombre", cliente.Nombre),
                                         new SqlParameter("@Apellido", cliente.Apellido),
                                         new SqlParameter("@Fecha_de_nacimiento", cliente.Fecha_Nacimiento),
                                         new SqlParameter("@Dni", cliente.Dni),
                                         new SqlParameter("@Direccion", cliente.Direccion)});
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public void Savechanges()
        {
            throw new NotImplementedException();
        }

        public void update(Cliente cliente)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Haciendo la actualizacion del cliente Dni {cliente.Dni}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(UpdateStatement, System.Data.CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@Nombre", cliente.Nombre),
                                         new SqlParameter("@Apellido", cliente.Apellido),
                                         new SqlParameter("@Fecha_nacimiento", cliente.Fecha_Nacimiento),
                                         new SqlParameter("@Dni", cliente.Dni),
                                         new SqlParameter("@Direccion", cliente.Direccion)});
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public IEnumerable<int> ValidacionInt()
        {
            List<int> Dnis = new List<int>();
            int dni = 0;
            string statement = "SELECT Dni FROM [dbo].[Cliente]";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo listado de DNI's de Clientes", EventLevel.Informational);
                using(var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        dni = int.Parse(values.ToString());
                        Dnis.Add(dni);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return Dnis;
        }

        public IEnumerable<string> ValidacionString()
        {
            throw new NotImplementedException();
        }
    }
}
