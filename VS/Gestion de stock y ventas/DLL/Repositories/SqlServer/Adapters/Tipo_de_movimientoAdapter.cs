using DLL.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories.SqlServer.Adapters
{
    public sealed class Tipo_de_movimientoAdapter : IEntityAdapter<Tipo_de_movimiento>
    {
        private readonly static Tipo_de_movimientoAdapter _instance = new Tipo_de_movimientoAdapter();

        public static Tipo_de_movimientoAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private Tipo_de_movimientoAdapter()
        {
            //Implent here the initialization of your singleton
        }

        public Tipo_de_movimiento Adapt(object[] values)
        {
            return new Tipo_de_movimiento
            {
                idTipo_de_movimiento = int.Parse(values[(int)Colums.IdTipo_de_movimiento].ToString()),
                Nombre = values[(int)Colums.Nombre].ToString(),
                Afecta_movimiento = int.Parse(values[(int)Colums.Afecta_caja].ToString())
            };
        }
        private enum Colums
        {
            IdTipo_de_movimiento,
            Nombre,
            Afecta_caja
        }
    }

}
