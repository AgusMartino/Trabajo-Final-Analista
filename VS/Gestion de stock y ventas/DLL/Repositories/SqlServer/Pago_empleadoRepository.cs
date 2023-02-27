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
    internal class Pago_empleadoRepository : IPagosRepository<Pago_Empleado>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Pago_empleado] (Id_empleado, Monto_pagado, Fecha_de_pago) VALUES (@Id_empleado, @Monto_pagado, @Fecha_de_pago)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Pago_empleado] SET () WHERE  Id_pago_empleado= @Id_pago_empleado";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Pago_empleado] WHERE  Id_pago_empleado = @Id_pago_empleado";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Pago_empleado] WHERE Id_pago_empleado = @Id_pago_empleado";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Pago_empleado]";
        }
        #endregion

        public void delete(Pago_Empleado obj)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Cancelando pago de empleado con id {obj.IdPagoEmpleado}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(DeleteStatement, System.Data.CommandType.Text, new SqlParameter("@Id_pago_empleado", obj.IdPagoEmpleado));
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public IEnumerable<Pago_Empleado> GetAll()
        {
            List<Pago_Empleado> pago_Empleados = new List<Pago_Empleado>();
            Pago_Empleado pago_Empleado = new Pago_Empleado();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo todos los pagos realizados a empleados", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        pago_Empleado = PagoEmpleadoAdapter.Current.Adapt(vs);
                        pago_Empleados.Add(pago_Empleado);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Empleados;
        }

        public Pago_Empleado GetOne(int id)
        {
            Pago_Empleado pago_Empleado = new Pago_Empleado();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo pago empleado con id {id}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text,
                                                        new SqlParameter("@Id_pago_empleado", id)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        pago_Empleado = PagoEmpleadoAdapter.Current.Adapt(vs);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Empleado;
        }

        public Pago_Empleado GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Pago_Empleado GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pago_Empleado> GetPagoEntreFecha(DateTime dateTimeInicio, DateTime dateTimeFin)
        {
            List<Pago_Empleado> pago_Empleados = new List<Pago_Empleado>();
            Pago_Empleado pago_Empleado = new Pago_Empleado();
            string statement = "select * from Pago_empleado where Fecha_de_pago between @Fehca_inicio and @Fecha_fin";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Pagos de empleado entre las fechas {dateTimeInicio} y {dateTimeFin}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text, new SqlParameter[]
                {
                    new SqlParameter("@Fehca_inicio", dateTimeInicio),
                    new SqlParameter("@Fecha_fin", dateTimeFin)
                }))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        pago_Empleado = PagoEmpleadoAdapter.Current.Adapt(vs);
                        pago_Empleados.Add(pago_Empleado);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Empleados;
        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Pago_Empleado pago_Empleado)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Registrando el pago del Empleado {pago_Empleado.Empleado.Dni}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@Id_empleado", pago_Empleado.Empleado.Dni),
                                         new SqlParameter("@Monto_pagado", pago_Empleado.MontoPagado),
                                         new SqlParameter("@Fecha_de_pago", pago_Empleado.Fecha_Pago)});
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

        public void update(Pago_Empleado obj)
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
