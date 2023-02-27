using SL.DAL.Contracts;
using SL.DOMAIN.SecurityComposite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Repository.Adapters
{
    public class PermisoAdapter : IEntityAdapter<Permiso>
    {
        #region Singleton
        private readonly static PermisoAdapter _instance = new PermisoAdapter();

            public static PermisoAdapter Current
            {
                get
                {
                    return _instance;
                }
            }

            private PermisoAdapter()
            {
                //Implent here the initialization of your singleton
            }
        #endregion
        public Permiso Adapt(object[] values)
        {
            return new Permiso
            {
                Id = int.Parse(values[(int)Colums.IdUsuario].ToString()),
                Nombre = values[(int)Colums.Nombre].ToString(),
                vista = values[(int)Colums.vista].ToString()
            };
        }
        private enum Colums
        {
            IdUsuario,
            Nombre,
            vista
        }
    }
}
