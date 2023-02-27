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

    public sealed class MateriaPrimaAdapter : IEntityAdapter<MateriaPrima>
    {
        #region Singleton
        private readonly static MateriaPrimaAdapter _instance = new MateriaPrimaAdapter();

        public static MateriaPrimaAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private MateriaPrimaAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public MateriaPrima Adapt(object[] values)
        {

            return new MateriaPrima
            {
                IdMateriaPrima = int.Parse(values[(int)Colums.IdMateriaPrima].ToString()),
                unidad_de_medida = Factory.Current.GetUnidadDeMedidaRepository().GetOne(int.Parse(values[(int)Colums.IdUnidadDeMedida].ToString())),
                Codigo = values[(int)Colums.CodigoMateriaPrima].ToString(),
                Nombre = values[(int)Colums.Nombre].ToString(),
                Costo = decimal.Parse(values[(int)Colums.Costo].ToString()),   
            };
        }
        private enum Colums
        {
            IdMateriaPrima,
            IdUnidadDeMedida,
            CodigoMateriaPrima,
            Nombre,
            Costo
        }
    }

}
