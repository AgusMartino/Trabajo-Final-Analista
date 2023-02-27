using DLL.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories.SqlServer.Adapters
{

    public sealed class EmpleadoAdapter : IEntityAdapter<Empleado>
    {
        #region Singleton
        private readonly static EmpleadoAdapter _instance = new EmpleadoAdapter();

        public static EmpleadoAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private EmpleadoAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public Empleado Adapt(object[] values)
        {
            return new Empleado
            {
                IdEmpleado = int.Parse(values[(int)Columns.id].ToString()),
                Dni = int.Parse(values[(int)Columns.Dni].ToString()),
                Nombre = values[(int)Columns.Nombre].ToString(),
                Apellido = values[(int)Columns.Apellido].ToString(),
                Fecha_nacimiento = DateTime.Parse(values[(int)Columns.Fecha_nacimiento].ToString()),
                Direccion = values[(int)Columns.Direccion].ToString()
            };
        }
        private enum Columns
        {
            id,
            Dni,
            Nombre,
            Apellido,
            Fecha_nacimiento,
            Direccion
        }
    }

}
