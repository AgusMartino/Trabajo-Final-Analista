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
    internal class Orden_de_compraRepository : IOrden_de_CompraRepository<Orden_de_Compra>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Orden_de_compra] (Id_pago_proveedor, Id_materiaprima, Cantidad, Subtotal) VALUES (@Id_Pago_Proveedor, @Id_materiaprima, @Cantidad, @Subtotal)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Orden_de_compra] SET (Id_pago_proveedor, Id_materiaprima, Cantidad, Subtotal) WHERE Id_Orden_compra = @Id_Orden_compra";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Orden_de_compra] WHERE Id_pago_proveedor = @Id_pago_proveedor";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Orden_de_compra] WHERE Id_orden_de_compra = @Id_orden_de_compra";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Orden_de_compra]";
        }
        #endregion

        public void delete(Orden_de_Compra orden_De_Compra)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Cancelando orden de compra del pago {orden_De_Compra.Pago_Proveedor.IdPagoProveedor}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(DeleteStatement, System.Data.CommandType.Text, new SqlParameter("@Id_Pago_Proveedor", orden_De_Compra.Pago_Proveedor.IdPagoProveedor));
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public IEnumerable<Orden_de_Compra> GetAll()
        {
            throw new NotImplementedException();
        }

        public Orden_de_Compra GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Orden_de_Compra GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Orden_de_Compra GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Orden_de_Compra> GetOrdenesDeCompra(int id)
        {
            List<Orden_de_Compra> orden_De_Compras = new List<Orden_de_Compra>();
            Orden_de_Compra orden_De_Compra = new Orden_de_Compra();
            try
            {
                string statement = "Select * from Orden_de_Compra where Id_pago_proveedor = @Id_pago_proveedor";
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Listado de ordenes de compra del pago con id {id}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text, new SqlParameter("@Id_pago_proveedor", id)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        orden_De_Compra = Orden_de_compraAdapter.Current.Adapt(vs);
                        orden_De_Compras.Add(orden_De_Compra);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return orden_De_Compras;

        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Orden_de_Compra orden)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Realizando Orden de compra de la materia prima {orden.materiaPrima.Codigo}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
                          new SqlParameter[] { new SqlParameter("@Id_pago_proveedor", orden.Pago_Proveedor.IdPagoProveedor),
                                               new SqlParameter("@Id_materiaprima", orden.materiaPrima.IdMateriaPrima),
                                               new SqlParameter("@Cantidad", orden.Cantidad),
                                               new SqlParameter("@Subtotal", orden.Subtotal)});
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

        public void update(Orden_de_Compra obj)
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
