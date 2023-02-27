using DAL.Tools;
using DLL.Contracts;
using DLL.Repositories.SqlServer.Adapters;
using DOMAIN.Productos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories.SqlServer.Productos
{
    internal class MateriaPrimaProductoRelationship : IGenericRelationship<MateriaPrima, Producto>
    {
        public void DeleteJoin(Producto producto)
        {
            //borrando componentes del producto para luego insertar novedades
            string statement = "DELETE FROM [dbo].[MateriaPrima_Producto] WHERE Id_producto = @Id_producto";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Eliminando relaciones del producto {producto.CodigoProducto}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(statement, System.Data.CommandType.Text, new SqlParameter("@Id_producto", producto.IdProducto));
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            
        }

        public List<MateriaPrima> GetComponentes(Producto producto)
        {
            //Obteniendo componentes del producto
            List<MateriaPrima> materiaPrimas = new List<MateriaPrima>();
            MateriaPrima materiaPrima = new MateriaPrima();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Componentes del producto {producto.CodigoProducto}", EventLevel.Informational);
                string statement = "Select mp.IdMateriaPrima, m.IdUnidad_de_medida, m.Codigo_MateriaPrima, m.Nombre, m.Costo, mp.Cantidad from MateriaPrima_Producto mp join Materia_Prima m on m.Id_materiaprima = mp.Id_materiaprima where mp.Id_producto = @Id_producto";
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text,
                                                        new SqlParameter("@Id_producto", producto.IdProducto)))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        materiaPrima = MateriaPrimaAdapter.Current.Adapt(values);
                        materiaPrima.Cantidad = decimal.Parse(values[5].ToString());
                        materiaPrimas.Add(materiaPrima);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }

            return materiaPrimas;
        }

        public List<Producto> GetFamilia(MateriaPrima obj)
        {
            // select idproducto from producto_materiaprima where idMateriprima = obj.id
            // a esa lista de relaciones hacerle un loop de productorepository.getone
            throw new NotImplementedException();
        }

        public void Join(MateriaPrima materiaPrima, Producto producto)
        {
            //insert into Producto_MateriaPrima(idproducto, idmateriaprima, cantidad) values(valores)
            string statement = "INSERT INTO[dbo].[MateriaPrima_Producto] (Id_materiaprima, Id_producto, Cantidad) VALUES(@Id_materiaprima, @Id_producto, @Cantidad)";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Haciendo el Alta de los componentes del producto{producto.CodigoProducto}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(statement, System.Data.CommandType.Text,
                                          new SqlParameter[] { new SqlParameter("@Id_materiaprima", materiaPrima.IdMateriaPrima),
                                                               new SqlParameter("@Id_producto", producto.IdProducto),
                                                               new SqlParameter("@Cantidad", materiaPrima.Cantidad)});
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }

        }
    }
}
