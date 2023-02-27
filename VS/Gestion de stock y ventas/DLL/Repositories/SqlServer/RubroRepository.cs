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
    internal class RubroRepository : IGenericRepository<Rubro>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Rubro] (Nombre, codigo_rubro) VALUES (@Nombre, @codigo_rubro)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Rubro] SET (Nombre = @Nombre) WHERE  codigo_rubro = @codigo_rubro";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Rubro] WHERE  Id_rubro = @Id_rubro";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Rubro] WHERE Id_rubro = @Id_rubro";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Rubro]";
        }
        #endregion

        public void delete(Rubro obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Rubro> GetAll()
        {
            List<Rubro> rubros = new List<Rubro>();
            Rubro rubro = default;
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo listado de Rubros", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        rubro = RubroAdapter.Current.Adapt(values);
                        rubros.Add(rubro);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }

            return rubros;
        }

        public Rubro GetOne(int id)
        {
            Rubro rubro = default;
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Rubro con id {id}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                                new SqlParameter("@Id_rubro", id)))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        rubro = RubroAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return rubro;
        }

        public Rubro GetOneCode(string code)
        {
            Rubro rubro = default;
            string statement = "SELECT * FROM [dbo].[Rubro] WHERE codigo_rubro = @codigo_rubro";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Rubro con codigo {code}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text,
                                new SqlParameter("@codigo_rubro", code)))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        rubro = RubroAdapter.Current.Adapt(values);
                    }
                }
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

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Rubro rubro)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Haciendo el alta del Rubro con Codigo {rubro.Codigo_Rubro}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@codigo_rubro", rubro.Codigo_Rubro),
                                         new SqlParameter("@Nombre", rubro.Nombre)});
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

        public void update(Rubro rubro)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Haciendo la actulizacion del Rubro con Codigo {rubro.Codigo_Rubro}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(UpdateStatement, System.Data.CommandType.Text,
                    new SqlParameter[] {new SqlParameter("@codigo_rubro", rubro.Codigo_Rubro),
                                        new SqlParameter("@Nombre", rubro.Nombre)});
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public IEnumerable<int> ValidacionInt()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> ValidacionString()
        {
            List<string> Codes = new List<string>();
            string Code = "";
            string statement = "SELECT codigo_rubro FROM [dbo].[Rubro]";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Listado de Codigos de Rubros", EventLevel.Informational);
                using(var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        Code = vs.ToString();
                        Codes.Add(Code);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return Codes;
        }
    }
}
