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
    internal class VentaRepository : IVentaRepository<Venta>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Venta] (Id_cliente, IdTipo_de_pago, Fecha_de_venta, Total) VALUES (@IdCliente, @IdTipo_de_pago, @Fecha_de_venta, @Total)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Venta] SET (Id_cliente,IdTipo_de_pago,Fecha_de_venta,Total) WHERE IdVenta = @IdVenta";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Venta] WHERE IdVenta = @IdVenta";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Venta] WHERE IdVenta = @IdVenta";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Venta]";
        }
        #endregion

        public void delete(Venta venta)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Cancelando Venta con id {venta.IdVenta}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(DeleteStatement, System.Data.CommandType.Text, new SqlParameter("@IdVenta", venta.IdVenta));
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public IEnumerable<Venta> GetAll()
        {
            List<Venta> ventas = new List<Venta>();
            Venta venta = new Venta();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniedo todas las ventas", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        venta = VentaAdapter.Current.Adapt(vs);
                        ventas.Add(venta);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return ventas;
        }

        public Venta GetId(DateTime dateTime)
        {
            Venta venta = default;
            string statement = "Select * from Venta where Fecha_de_venta = @Fecha_de_venta";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniedo Venta realizada con fecha {dateTime}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text,
                                                        new SqlParameter("@Fecha_de_venta", dateTime)))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        venta = VentaAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return venta;
        }

        public Venta GetOne(int id)
        {
            Venta venta = new Venta();
            try
            {
                using(var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text, new SqlParameter("@IdVenta", id)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        venta = VentaAdapter.Current.Adapt(vs);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return venta;
        }

        public Venta GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Venta GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Venta> GetVentasEntreFechas(DateTime DateTimeInicio, DateTime DateTimeFin)
        {
            List<Venta> ventas = new List<Venta>();
            Venta venta = new Venta();
            string statement = "select * from Venta where Fecha_de_venta between @Fehca_inicio and @Fecha_fin";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniedo Ventas entre las fechas {DateTimeInicio} y {DateTimeInicio}", EventLevel.Informational);
                using(var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text, new SqlParameter[]
                {
                    new SqlParameter("@Fehca_inicio", DateTimeInicio),
                    new SqlParameter("@Fecha_fin", DateTimeFin)
                }))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        venta = VentaAdapter.Current.Adapt(vs);
                        ventas.Add(venta);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return ventas;
        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Venta venta)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Realizando venta con fecha {venta.Fecha_de_Venta}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
                                          new SqlParameter[] { new SqlParameter("@IdCliente", venta.cliente.IdCliente),
                                                               new SqlParameter("@IdTipo_de_pago", venta.tipo_De_Pago.IdTipo_de_pago),
                                                               new SqlParameter("@Fecha_de_venta", venta.Fecha_de_Venta),
                                                               new SqlParameter("@Total", venta.Total)});
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

        public void update(Venta obj)
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
