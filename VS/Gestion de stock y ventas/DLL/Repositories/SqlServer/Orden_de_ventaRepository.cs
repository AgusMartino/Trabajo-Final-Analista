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
    internal class Orden_de_ventaRepository : IOrden_de_ventaRepository<Orden_de_Venta>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Orden_de_venta] (IdVenta, Id_prducto, Cantidad, SubTotal) VALUES (@IdVenta, @Id_prducto, @Cantidad, @SubTotal)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Orden_de_venta] SET (IdVenta, Id_prducto, Cantidad, SubTotal) WHERE Id_orden_de_venta = @Id_orden_de_venta";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Orden_de_venta] WHERE Id_orden_de_venta = @Id_orden_de_venta";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Orden_de_venta] WHERE Id_orden_de_venta = @Id_orden_de_venta";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Orden_de_venta]";
        }
        #endregion

        public void delete(Orden_de_Venta orden_De_Venta)
        {
            try
            {
                string statement = "DELETE FROM [dbo].[Orden_de_Venta] WHERE IdVenta = @IdVenta";
                SL.Services.LoggerManager.GetInstance().Write($"Cancelando ordenes de venta de la venta con id {orden_De_Venta.venta.IdVenta}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(statement, System.Data.CommandType.Text, new SqlParameter("@IdVenta", orden_De_Venta.venta.IdVenta));
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public IEnumerable<Orden_de_Venta> GetAll()
        {
            throw new NotImplementedException();
        }

        public Orden_de_Venta GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Orden_de_Venta GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Orden_de_Venta GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Orden_de_Venta> GetOrdenes(int id)
        {
            List<Orden_de_Venta> orden_De_Ventas = new List<Orden_de_Venta>();
            Orden_de_Venta orden_De_Venta = new Orden_de_Venta();
            try
            {
                string statement = "SELECT* FROM[dbo].[Orden_de_Venta] WHERE IdVenta = @IdVenta";
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo las ordenes de venta, de la venta con id {id}", EventLevel.Informational);
                using(var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text, new SqlParameter("@IdVenta", id)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        orden_De_Venta = Orden_de_ventaAdapter.Current.Adapt(vs);
                        orden_De_Ventas.Add(orden_De_Venta);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return orden_De_Ventas;
        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Orden_de_Venta orden)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Realizando orden de venta de la venta con id {orden.venta.IdVenta}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
                          new SqlParameter[] { new SqlParameter("@IdVenta", orden.venta.IdVenta),
                                               new SqlParameter("@Id_prducto", orden.producto.IdProducto),
                                               new SqlParameter("@Cantidad", orden.Cantidad),
                                               new SqlParameter("@SubTotal", orden.Subtotal)});
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

        public void update(Orden_de_Venta obj)
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
