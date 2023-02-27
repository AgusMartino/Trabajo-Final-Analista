using DLL.Contracts;
using DLL.Factories;
using DOMAIN.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories.SqlServer.Adapters
{
    public sealed class ProductoAdapter : IEntityAdapter<Producto>
    {
        #region Singleton
        private readonly static ProductoAdapter _instance = new ProductoAdapter();

        public static ProductoAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private ProductoAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public Producto Adapt(object[] values)
        {
            return new Producto
            {
                IdProducto = int.Parse(values[(int)Colums.IdProdcuto].ToString()),
                rubro = Factory.Current.GetRubroRepository().GetOne(int.Parse(values[(int)Colums.rubro].ToString())),
                CodigoProducto = values[(int)Colums.CodigoProducto].ToString(),
                Nombre = values[(int)Colums.Nombre].ToString(),
                Precio = decimal.Parse(values[(int)Colums.Precio].ToString()),
                Costo = decimal.Parse(values[(int)Colums.Costo].ToString())
            };
        }
        private enum Colums
        {
            IdProdcuto,
            rubro,
            CodigoProducto,
            Nombre,
            Precio,
            Costo
        }
    }

}
