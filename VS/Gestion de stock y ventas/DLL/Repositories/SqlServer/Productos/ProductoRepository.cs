using DAL.Tools;
using DLL.Contracts;
using DLL.Repositories.SqlServer.Adapters;
using DOMAIN.Productos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories.SqlServer.Productos
{
    internal class ProductoRepository : IGenericRepository<Producto>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Producto] (Id_rubro, codigo_producto, Nombre, Precio, Costo) VALUES (@Id_rubro, @codigo_producto, @Nombre, @Precio, @Costo)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Producto] SET Id_rubro = @Id_rubro, codigo_producto = @codigo_producto, Nombre = @Nombre, Precio = @Precio, Costo = @Costo WHERE Id_producto = @Id_producto";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Producto] WHERE  = @";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Producto] WHERE Id_producto = @Id_producto";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Producto]";
        }
        #endregion

        public void delete(Producto obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> GetAll()
        {
            List<Producto> productos = new List<Producto>();
            Producto producto = default; 
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo lista de Productos", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        producto = ProductoAdapter.Current.Adapt(values);
                        productos.Add(producto);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return productos;
        }

        public Producto GetOne(int id)
        {
            Producto producto = default;
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo el producto con el id {id}", EventLevel.Informational);
                using(var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text, new SqlParameter("@Id_producto", id)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        producto = ProductoAdapter.Current.Adapt(vs);
                    }
                }
                
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return producto;
        }

        public Producto GetOneCode(string code)
        {
            Producto producto = default;
            string statement = "SELECT * FROM [dbo].[Producto] WHERE codigo_producto = @codigo_producto";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo el producto con el codigo {code}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text,
                                                        new SqlParameter("@codigo_producto", code)))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        producto = ProductoAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return producto;
        }

        public Producto GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Producto producto)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Haciendo el Alta del Producto {producto.CodigoProducto}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
                        new SqlParameter[] { new SqlParameter("@Id_rubro", producto.rubro.IdRubro),
                                             new SqlParameter("@codigo_producto", producto.CodigoProducto),
                                             new SqlParameter("@Nombre", producto.Nombre),
                                             new SqlParameter("@Precio", producto.Precio),
                                             new SqlParameter("@Costo", producto.Costo)
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

        public void update(Producto producto)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Haciendo la Actualizacion del Producto Dni {producto.CodigoProducto}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(UpdateStatement, System.Data.CommandType.Text,
                        new SqlParameter[] { new SqlParameter("@Id_rubro", producto.rubro.IdRubro),
                                             new SqlParameter("@codigo_producto", producto.CodigoProducto),
                                             new SqlParameter("@Nombre", producto.Nombre),
                                             new SqlParameter("@Precio", producto.Precio),
                                             new SqlParameter("@Costo", producto.Costo),
                                             new SqlParameter("@IdProducto", producto.IdProducto)
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
            List<string> Codes = new List<string>();
            string Code = "";
            string statement = "SELECT codigo_producto FROM [dbo].[Producto]";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Listado de Codigos de Productos", EventLevel.Informational);
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
