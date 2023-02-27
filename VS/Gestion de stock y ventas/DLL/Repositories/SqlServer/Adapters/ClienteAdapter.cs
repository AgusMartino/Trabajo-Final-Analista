using DLL.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories.SqlServer.Adapters
{

    public sealed class ClienteAdapter : IEntityAdapter<Cliente>
    {
        #region Singleton
        private readonly static ClienteAdapter _instance = new ClienteAdapter();

        public static ClienteAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private ClienteAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public Cliente Adapt(object[] values)
        {
            return new Cliente
            {
                IdCliente = int.Parse(values[(int)Columns.id].ToString()),
                Dni = int.Parse(values[(int)Columns.Dni].ToString()),
                Nombre = values[(int)Columns.Nombre].ToString(),
                Apellido = values[(int)Columns.Apellido].ToString(),
                Fecha_Nacimiento = Convert.ToDateTime(values[(int)Columns.Fecha_Nacimiento]),
                Direccion = values[(int)Columns.Direccion].ToString()
            };
        }
        private enum Columns
        {
            id,
            Dni,
            Nombre,
            Apellido,
            Fecha_Nacimiento,
            Direccion
        }
        
    }

}
