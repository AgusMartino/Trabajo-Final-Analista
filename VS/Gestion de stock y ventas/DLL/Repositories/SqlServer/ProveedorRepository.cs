using DAL.Tools;
using DLL.Contracts;
using DLL.Repositories.SqlServer.Adapters;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories.SqlServer
{
    internal class ProveedorRepository : IGenericRepository<Proveedor>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Proveedor] (Cuit, Nombre) VALUES (@Cuit, @Nombre)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Proveedor] SET (Nombre = @Nombre) WHERE Cuit = @Cuit";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Proveedor] WHERE Id_proveedor = @Id_proveedor";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Proveedor] WHERE  Id_proveedor = @Id_proveedor";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Proveedor]";
        }
        #endregion

        public void delete(Proveedor obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Proveedor> GetAll()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            Proveedor proveedor = default;
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo listado de Proveedores", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        proveedor = ProveedorAdapter.Current.Adapt(values);
                        proveedores.Add(proveedor);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return proveedores;
        }

        public Proveedor GetOne(int id)
        {
            Proveedor proveedor = default;
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo proveedor con id {id}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                                new SqlParameter("@Id_proveedor", id)))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        proveedor = ProveedorAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return proveedor;
        }

        public Proveedor GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Proveedor GetOneDni(int Cuit)
        {
            Proveedor proveedor = default;
            string statement = "SELECT * FROM [dbo].[Proveedor] WHERE  Cuit = @Cuit";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo proveedor con Cuit {Cuit}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text,
                                new SqlParameter("@Cuit", Cuit)))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        proveedor = ProveedorAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return proveedor;
        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Proveedor proveedor)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Haciendo el alta del Proveedor con Cuit {proveedor.Cuit}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@Cuit", proveedor.Cuit),
                                         new SqlParameter("@Nombre", proveedor.Nombre)});
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

        public void update(Proveedor proveedor)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Haciendo la Actulizacion del Proveedor con Cuit {proveedor.Cuit}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(UpdateStatement, System.Data.CommandType.Text,
                    new SqlParameter[] {new SqlParameter("@Nombre", proveedor.Nombre),
                                        new SqlParameter("@Cuit", proveedor.Cuit)});
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public IEnumerable<int> ValidacionInt()
        {
            List<int> Cuits = new List<int>();
            int cuit = 0;
            string statement = "SELECT Cuit FROM [dbo].[Proveedor]";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo listado de Cuit's de Proveedores", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        cuit = int.Parse(values.ToString());
                        Cuits.Add(cuit);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return Cuits;
        }

        public IEnumerable<string> ValidacionString()
        {
            throw new NotImplementedException();
        }
    }
}
