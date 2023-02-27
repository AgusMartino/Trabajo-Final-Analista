using DAL.Tools;
using SL.DAL.Contracts;
using SL.DAL.Repository.Adapters;
using SL.DOMAIN.SecurityComposite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Repository
{
    internal class UsuarioRepository : IUsuarioRepository<Usuario>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Usuario] (Usuario, Contraseña, Habilitado) VALUES (@Usuario, @Contraseña, @Habilitado)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Usuario] SET Usuario = @Usuario, Habilitado = @Habilitado WHERE IdUsuario = @IdUsuario";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Usuario] WHERE  IdUsuario = @IdUsuario";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Usuario] WHERE IdUsuario = @IdUsuario";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Usuario]";
        }

        public void Cambiar_contraseña(Usuario obj)
        {
            string statemet = "UPDATE [dbo].[Usuario] SET Cotraseña = @Contraseña WHERE IdUsuario = @IdUsuario";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Actualizando contraseña del usuario {obj.IdUsuario}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(statemet, System.Data.CommandType.Text, new SqlParameter[]
                {
                    new SqlParameter("@Contraseña", obj.Contraseña),
                    new SqlParameter("@IdUsuario", obj.IdUsuario)
                });
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        #endregion

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = new Usuario();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Lista de Usuarios", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        usuario = UsuarioAdapter.Current.Adapt(vs);
                        usuarios.Add(usuario);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return usuarios;
        }

        public Usuario GetId(string Nombre)
        {
            Usuario usuario = new Usuario();
            string statement = "Select * from Usuario where Usuario = @Usuario";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo id de Usuario {Nombre}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text, new SqlParameter("@Usuario", Nombre)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        usuario = UsuarioAdapter.Current.Adapt(vs);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return usuario;
        }

        public Usuario GetOne(int id)
        {
            Usuario usuario = new Usuario();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Usuario con id {id}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text, new SqlParameter("@IdUsuario", id)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        usuario = UsuarioAdapter.Current.Adapt(vs);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return usuario;
        }

        public void Insert(Usuario usuario)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Alta de usuario {usuario.usuario}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, new SqlParameter[]
                {
                   new SqlParameter("@Usuario", usuario.usuario ),
                   new SqlParameter("@Contraseña", usuario.Contraseña),
                   new SqlParameter("@Habilitado", usuario.Habilitado),
                });
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public Usuario Login(Usuario usuario)
        {
            Usuario usuarioLogin = new Usuario();
            try
            {
                string statement = "Select * from Usuario where Usuario = @Usuario and Contraseña = @Contraseña";
                SL.Services.LoggerManager.GetInstance().Write($"Haciendo Login", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text, new SqlParameter[] { 
                                                       new SqlParameter("@Usuario", usuario.usuario),
                                                       new SqlParameter("@Contraseña", usuario.Contraseña)}))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        usuarioLogin = UsuarioAdapter.Current.Adapt(vs);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return usuarioLogin;
        }

        public void Update(Usuario usuario)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Actualizacion de usuario con id {usuario.IdUsuario}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(UpdateStatement, System.Data.CommandType.Text, new SqlParameter[]
                {
                   new SqlParameter("@IdUsuario", usuario.IdUsuario),
                   new SqlParameter("@Usuario", usuario.usuario ),
                   new SqlParameter("@Habilitado", usuario.Habilitado),
                });
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
    }
}
