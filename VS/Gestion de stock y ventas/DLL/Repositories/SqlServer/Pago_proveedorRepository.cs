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
    internal class Pago_proveedorRepository : IPagoProveedorRepository<Pago_Proveedor>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Pago_Proveedor] (Id_proveedor, Fecha_de_pago, Total, Monto_pagado, Monto_adeudado) VALUES (@Id_proveedor, @Fecha_de_pago, @Total, @Monto_pagado, @Monto_adeudado)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Pago_Proveedor] SET Id_proveedor = @Id_proveedor, Fecha_de_pago = @Fecha_de_pago, Total = @Total, Monto_pagado = @Monto_pagado, Monto_adeudado = @Monto_adeudado  WHERE Id_Pago = @Id_Pago";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Pago_Proveedor] WHERE  Id_Pago = @Id_Pago";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Pago_Proveedor] WHERE Id_Pago = @Id_Pago";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Pago_Proveedor]";
        }
        #endregion

        public void delete(Pago_Proveedor obj)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Cancelando el pago de proveedor con id {obj.IdPagoProveedor}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(DeleteStatement, System.Data.CommandType.Text, new SqlParameter("@Id_Pago", obj.IdPagoProveedor));
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public IEnumerable<Pago_Proveedor> GetAll()
        {
            List<Pago_Proveedor> pago_Proveedors = new List<Pago_Proveedor>();
            Pago_Proveedor pago_Proveedor = new Pago_Proveedor();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniedo todos los pagos de proveedores", EventLevel.Informational);
                using(var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        pago_Proveedor = Pago_proveedorAdapter.Current.Adapt(vs);
                        pago_Proveedors.Add(pago_Proveedor);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Proveedors;
        }

        public Pago_Proveedor GetMontoAdeudado(int id)
        {
            Pago_Proveedor pago_proveedor = new Pago_Proveedor();
            string statement = "Select Top 1 * from Pago_Proveedor where Id_proveedor = @Id_proveedor ORDER BY Id_Pago DESC";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniedo ultimo registro del proveedor con id {id}", EventLevel.Informational);
                using(var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text,
                                                         new SqlParameter("@Id_proveedor", id)))
                {
                    while (dr.Read())
                    {
                        object[] value = new object[dr.FieldCount];
                        dr.GetValues(value);
                        pago_proveedor = Pago_proveedorAdapter.Current.Adapt(value);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_proveedor;
        }

        public Pago_Proveedor GetOne(int id)
        {
            Pago_Proveedor pago_Proveedor = new Pago_Proveedor();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniedo pago proveedor realizado con id {id}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text, new SqlParameter("@Id_Pago", id)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        pago_Proveedor = Pago_proveedorAdapter.Current.Adapt(vs);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Proveedor;
        }

        public Pago_Proveedor GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Pago_Proveedor GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pago_Proveedor> GetPagosEntreFecha(DateTime dateTimeInicio, DateTime dateTimeFin)
        {
            List<Pago_Proveedor> pago_Proveedors = new List<Pago_Proveedor>();
            Pago_Proveedor pago_Proveedor = new Pago_Proveedor();
            string statement = "select * from Pago_Proveedor where Fecha_de_pago between @Fehca_inicio and @Fecha_fin";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniedo los pagos de proveedor entre las fechas {dateTimeInicio} y {dateTimeFin}", EventLevel.Informational);
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
                        pago_Proveedor = Pago_proveedorAdapter.Current.Adapt(vs);
                        pago_Proveedors.Add(pago_Proveedor);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Proveedors;
        }

        public Pago_Proveedor GetPago_proveedorId(DateTime Fecha_de_pago)
        {
            Pago_Proveedor pago_Proveedor = new Pago_Proveedor();
            string statement = "Select * from Pago_Proveedor where Fecha_de_pago = @Fecha_de_pago";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniedo pago proveedor realizado con fecha {Fecha_de_pago}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text,
                                                        new SqlParameter("@Fecha_de_pago", Fecha_de_pago)))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        pago_Proveedor = Pago_proveedorAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return pago_Proveedor;
        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Pago_Proveedor pago_Proveedor)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Registrando Pago al proveedor {pago_Proveedor.proveedor.Cuit}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
                                          new SqlParameter[] { new SqlParameter("@Id_proveedor", pago_Proveedor.proveedor.IdProveedor),
                                                               new SqlParameter("@Fecha_de_pago",pago_Proveedor.Fecha_Pago),
                                                               new SqlParameter("@Total", pago_Proveedor.Total),
                                                               new SqlParameter("@Monto_pagado", pago_Proveedor.Monto_pagado),
                                                               new SqlParameter("@Monto_adeudado",pago_Proveedor.Monto_adeudado)});
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

        public void update(Pago_Proveedor pago_Proveedor)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Actualizando Pago al proveedor {pago_Proveedor.proveedor.Cuit}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(UpdateStatement, System.Data.CommandType.Text,
                                          new SqlParameter[] { new SqlParameter("@Id_proveedor", pago_Proveedor.proveedor.IdProveedor),
                                                               new SqlParameter("@Fecha_de_pago",pago_Proveedor.Fecha_Pago),
                                                               new SqlParameter("@Total", pago_Proveedor.Total),
                                                               new SqlParameter("@Monto_pagado", pago_Proveedor.Monto_pagado),
                                                               new SqlParameter("@Monto_adeudado",pago_Proveedor.Monto_adeudado),
                                                               new SqlParameter("@Id_Pago", pago_Proveedor.IdPagoProveedor)});
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
