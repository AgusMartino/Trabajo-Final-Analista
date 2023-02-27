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
    internal class TurnoRepository : ITurnoRepository<Turno>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Turno] (Caja_inicial, Fecha_de_inicio) VALUES (@Caja_inicial, @Fecha_de_inicio)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Turno] SET Caja_inicial = @Caja_inicial , Fecha_de_inicio = @Fecha_de_inicio, Fecha_de_cierre = @Fecha_de_cierre WHERE IdTurno = @IdTurno";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Turno] WHERE IdTurno = @IdTurno";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Turno] WHERE IdTurno = @IdTurno";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Turno]";
        }
        #endregion

        public void delete(Turno obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Turno> GetAll()
        {
            List<Turno> turnos = new List<Turno>();
            Turno turno = new Turno();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Lista de Turnos", EventLevel.Informational);
                using(var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        turno = TurnoAdapter.Current.Adapt(vs);
                        turnos.Add(turno);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return turnos;
        }

        public Turno GetOne(int id)
        {
            Turno turno = new Turno();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Turno con id {id}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text, new SqlParameter("@IdTurno", id)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        turno = TurnoAdapter.Current.Adapt(vs);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return turno;
        }

        public Turno GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Turno GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public Turno GetTurno(DateTime dateTime)
        {
            Turno turno = new Turno();
            string statement = "SELECT * FROM [dbo].[Turno] WHERE Fecha_de_inicio = @Fecha_de_inicio";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Turno con Fecha {dateTime}", EventLevel.Informational);
                using(var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text, new SqlParameter("@Fecha_de_inicio", dateTime)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        if(vs[3] == DBNull.Value)
                        {
                            vs[3] = null;
                        }
                        turno = TurnoAdapter.Current.Adapt(vs);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return turno;
        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Turno turno)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Dando de alta Turno con Fecha {turno.Fecha_de_inicio}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, new SqlParameter[]
                {

                    new SqlParameter("@Caja_inicial", turno.Caja_inicial),
                    new SqlParameter("@Fecha_de_inicio", turno.Fecha_de_inicio),
                });
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

        public void update(Turno turno)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Actualizando fecha de cierre del Turno con id {turno.IdTurno}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(UpdateStatement, System.Data.CommandType.Text, new SqlParameter[]
                {

                    new SqlParameter("@Caja_inicial", turno.Caja_inicial),
                    new SqlParameter("@Fecha_de_inicio", turno.Fecha_de_inicio),
                    new SqlParameter("@Fecha_de_cierre", turno.Fecha_de_cierre),
                    new SqlParameter("@IdTurno", turno.IdTurno)
                });
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
            throw new NotImplementedException();
        }
    }
}
