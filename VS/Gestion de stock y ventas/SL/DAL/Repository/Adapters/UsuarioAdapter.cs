using SL.DAL.Contracts;
using SL.DAL.Factories;
using SL.DOMAIN.SecurityComposite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Repository.Adapters
{
    public class UsuarioAdapter : IEntityAdapter<Usuario>
    {
        #region Singleton
        private readonly static UsuarioAdapter _instance = new UsuarioAdapter();

            public static UsuarioAdapter Current
            {
                get
                {
                    return _instance;
                }
            }

            private UsuarioAdapter()
            {
                //Implent here the initialization of your singleton
            }
        #endregion

        public Usuario Adapt(object[] values)
        {
            Usuario usuario = new Usuario
            {
                IdUsuario = int.Parse(values[(int)Columns.IdUsuario].ToString()),
                usuario = values[(int)Columns.Usuario].ToString(),
                Contraseña = values[(int)Columns.Contraseña].ToString(),
                Habilitado = (bool?)values[(int)Columns.Habilitado]
            };
            return usuario;
        }
        private enum Columns
        {
            IdUsuario,
            Usuario,
            Contraseña,
            Habilitado

        }
    }
}
