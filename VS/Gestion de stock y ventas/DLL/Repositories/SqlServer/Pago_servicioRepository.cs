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
    internal class Pago_servicioRepository : IPagosRepository<Pago_Servicio>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Pago_servicio] (Id_servicio, Monto_pagado, Fecha_de_pago) VALUES (@Id_servicio, @Monto_pagado, @Fecha_de_pago)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Pago_servicio] SET (Id_servicio, Monto_pagado, Fecha_de_pago) WHERE  = @";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Pago_servicio] WHERE  Id_pago_servicio = @Id_pago_servicio";
        }

        private string SelectOneStatement
        {
            get => "SELECT *  FROM [dbo].[Pago_servicio] WHERE  Id_pago_servicio = @Id_pago_servicio";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Pago_servicio]";
        }
        #endregion

        public void delete(Pago_Servicio obj)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Cancelando el pago de servicio con id {obj.IdPagoServicio}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(DeleteStatement, System.Data.CommandType.Text, new SqlParameter("@Id_pago_servicio", obj.IdPagoServicio));
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public IEnumerable<Pago_Servicio> GetAll()
        {
            List<Pago_Servicio> pago_Servicios = new List<Pago_Servicio>();
            Pago_Servicio pago_Servicio = new Pago_Servicio();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo pagos realizados de servicios", EventLevel.Informational);
                using(var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        pago_Servicio = PagoServicioAdapter.Current.Adapt(vs);
                        pago_Servicios.Add(pago_Servicio);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Servicios;
        }

        public Pago_Servicio GetOne(int id)
        {
            Pago_Servicio pago_Servicio = new Pago_Servicio();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo pago de servicio con id {id}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                                                        new SqlParameter("@Id_pago_servicio", id)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        pago_Servicio = PagoServicioAdapter.Current.Adapt(vs);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Servicio;
        }

        public Pago_Servicio GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Pago_Servicio GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pago_Servicio> GetPagoEntreFecha(DateTime dateTimeInicio, DateTime dateTimeFin)
        {
            List<Pago_Servicio> pago_Servicios = new List<Pago_Servicio>();
            Pago_Servicio pago_Servicio = new Pago_Servicio();
            string statement = "select * from Pago_servicio where Fecha_de_pago between @Fehca_inicio and @Fecha_fin";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo pago de servicios entre las fechas {dateTimeInicio} y {dateTimeFin}", EventLevel.Informational);
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
                        pago_Servicio = PagoServicioAdapter.Current.Adapt(vs);
                        pago_Servicios.Add(pago_Servicio);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Servicios;
        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Pago_Servicio pago_Servicio)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Registrando el pago del Servicio {pago_Servicio.servicio.Nombre}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@Id_servicio", pago_Servicio.servicio.IdServicio),
                                         new SqlParameter("@Monto_pagado", pago_Servicio.MontoPagado),
                                         new SqlParameter("@Fecha_de_pago", pago_Servicio.Fecha_Pago)});
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

        public void update(Pago_Servicio obj)
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
