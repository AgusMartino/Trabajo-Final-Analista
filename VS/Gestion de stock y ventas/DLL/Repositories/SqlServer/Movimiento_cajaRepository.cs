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
    internal class Movimiento_cajaRepository : IGenericRepository<Movimiento_Caja>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Movimientos_caja] (Cantidad, IdTipo_de_movimiento, idTipo_de_pago, Fecha_de_movimiento) VALUES (@Cantidad, @IdTipo_de_movimiento, @idTipo_de_pago, @Fecha_de_movimiento)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Movimientos_caja] SET Cantidad = @Cantidad, IdTipo_de_movimiento = @IdTipo_de_movimiento, idTipo_de_pago = @idTipo_de_pago , Fecha_de_movimiento = @Fecha_de_movimiento WHERE IdMovimiento = @IdMovimiento";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Movimientos_caja] WHERE IdMovimiento = @IdMovimiento";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Movimientos_caja] WHERE IdMovimiento = @IdMovimiento";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Movimientos_caja]";
        }
        #endregion

        public void delete(Movimiento_Caja movimiento_Caja)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Cancelando movimiento de caja con id {movimiento_Caja.IdMovimiento_caja}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(DeleteStatement, System.Data.CommandType.Text, new SqlParameter("@IdMovimiento", movimiento_Caja.IdMovimiento_caja));
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public IEnumerable<Movimiento_Caja> GetAll()
        {
            List<Movimiento_Caja> movimiento_Cajas = new List<Movimiento_Caja>();
            Movimiento_Caja movimiento_Caja = new Movimiento_Caja();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Lista de movimientos de caja", EventLevel.Informational);
                using( var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        movimiento_Caja = Movimiento_cajaAdapter.Current.Adapt(vs);
                        movimiento_Cajas.Add(movimiento_Caja);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return movimiento_Cajas;
        }

        public Movimiento_Caja GetOne(int id)
        {
            Movimiento_Caja movimiento_Caja = new Movimiento_Caja();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo movimiento de caja con id {id}", EventLevel.Informational);
                using(var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text, new SqlParameter("@IdMovimiento", id)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        movimiento_Caja = Movimiento_cajaAdapter.Current.Adapt(vs);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return movimiento_Caja;
        }

        public Movimiento_Caja GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Movimiento_Caja GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Movimiento_Caja movimiento_Caja)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Realizando movieminto de caja con fecha {movimiento_Caja.Fecha_de_movimiento}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, new SqlParameter[]
                {
                    new SqlParameter("@Cantidad", movimiento_Caja.cantidad),
                    new SqlParameter("@IdTipo_de_movimiento", movimiento_Caja.tipo_De_Movimiento.idTipo_de_movimiento),
                    new SqlParameter("@idTipo_de_pago", movimiento_Caja.tipo_De_Pago.IdTipo_de_pago),
                    new SqlParameter("@Fecha_de_movimiento", movimiento_Caja.Fecha_de_movimiento)
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

        public void update(Movimiento_Caja obj)
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
