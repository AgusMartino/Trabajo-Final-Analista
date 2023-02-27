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
    internal class Tipo_de_movimientoRepository : IGenericRepository<Tipo_de_movimiento>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Tipo_de_movimiento] (Nombre, Afecta_movimeinto) VALUES (@Nombre, @Afecta_movimeinto)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Tipo_de_movimiento] SET Nombre = @Nombre, Afecta_movimeinto = @Afecta_movimeinto WHERE IdTipo_de_movimiento = @IdTipo_de_movimiento";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Tipo_de_movimiento] WHERE IdTipo_de_movimiento = @IdTipo_de_movimiento";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Tipo_de_movimiento] WHERE IdTipo_de_movimiento = @IdTipo_de_movimiento";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Tipo_de_movimiento]";
        }
        #endregion

        public void delete(Tipo_de_movimiento obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tipo_de_movimiento> GetAll()
        {
            List<Tipo_de_movimiento> tipo_De_Movimientos = new List<Tipo_de_movimiento>();
            Tipo_de_movimiento tipo_De_Movimiento = new Tipo_de_movimiento();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Lista de tipos de movimiento", EventLevel.Informational);
                using(var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        tipo_De_Movimiento = Tipo_de_movimientoAdapter.Current.Adapt(vs);
                        tipo_De_Movimientos.Add(tipo_De_Movimiento);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return tipo_De_Movimientos;
        }

        public Tipo_de_movimiento GetOne(int id)
        {
            Tipo_de_movimiento tipo_De_Movimiento = new Tipo_de_movimiento();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo tipos de movimiento con id {id}", EventLevel.Informational);
                using(var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text, new SqlParameter("@IdTipo_de_movimiento", id)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        tipo_De_Movimiento = Tipo_de_movimientoAdapter.Current.Adapt(vs);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return tipo_De_Movimiento;
        }

        public Tipo_de_movimiento GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Tipo_de_movimiento GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Tipo_de_movimiento obj)
        {
            throw new NotImplementedException();
        }

        public void Savechanges()
        {
            throw new NotImplementedException();
        }

        public void update(Tipo_de_movimiento obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> ValidacionInt()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> ValidacionString()
        {
            throw new NotImplementedException();
        }
    }
}
