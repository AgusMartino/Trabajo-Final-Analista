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
    internal class ServicioRepository : IGenericRepository<Servicio>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Servicio] (Nombre, codigo_servicio) VALUES (@Nombre, @codigo_servicio)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Servicio] SET (Nombre = @Nombre) WHERE codigo_servicio = @codigo_servicio";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Servicio] WHERE codigo_servicio = @codigo_servicio";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Servicio] WHERE Id_servicio = @Id_servicio";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Servicio]";
        }
        #endregion

        public void delete(Servicio obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Servicio> GetAll()
        {
            List<Servicio> servicios = new List<Servicio>();
            Servicio servicio = default;
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo listado de Servicios", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        servicio = ServicioAdapter.Current.Adapt(values);
                        servicios.Add(servicio);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return servicios;
        }

        public Servicio GetOne(int id)
        {
            Servicio servicio = default;
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Servicio con id {id}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                                new SqlParameter("@Id_servicio", id)))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        servicio = ServicioAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return servicio;
        }

        public Servicio GetOneCode(string code)
        {
            Servicio servicio = default;
            string statement = "SELECT * FROM [dbo].[Servicio] WHERE codigo_servicio = @codigo_servicio";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Servicio con codigo {code}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text,
                                new SqlParameter("@codigo_servicio", code)))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        servicio = ServicioAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return servicio;
        }

        public Servicio GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Servicio servicio)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Haciendo el alta del Servicio con Codigo {servicio.CodigoServicio}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@codigo_servicio", servicio.CodigoServicio),
                                         new SqlParameter("@Nombre", servicio.Nombre)});
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

        public void update(Servicio servicio)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Haciendo la actualizacion del Servicio con Codigo {servicio.CodigoServicio}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(UpdateStatement, System.Data.CommandType.Text,
                    new SqlParameter[] {new SqlParameter("@codigo_servicio", servicio.CodigoServicio),
                                        new SqlParameter("@Nombre", servicio.Nombre)});
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
            string statement = "SELECT codigo_servicio FROM [dbo].[Servicio]";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Listado de Codigos de Servicios", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text))
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
