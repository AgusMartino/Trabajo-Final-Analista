using BLL.BusinessExceptions;
using SL.BLL.BusinessExceptions;
using SL.BLL.Contracts;
using SL.DAL.Contracts;
using SL.DAL.Factories;
using SL.DOMAIN;
using SL.DOMAIN.SecurityComposite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.Services
{
    public class UsuarioService : IGenericBusinessLogic<Usuario>
    {
        #region Singleton

        private readonly static UsuarioService _instance = new UsuarioService();

            public static UsuarioService Current
            {
                get
                {
                    return _instance;
                }
            }

            private UsuarioService()
            {
                //Implent here the initialization of your singleton
            }
        #endregion Singleton
        IUsuarioRepository<Usuario> usuarioRepository = Factory.Current.GetUsuarioRepository();
        IGenericRelationship<Perfil, Usuario> PerfilRelationship = Factory.Current.GetUsuarioPerfilRepository();
        IGenericRelationship<Permiso, Usuario> PermisoRelationship = Factory.Current.GetUsuarioPermisoRepository();

        public void delete(Usuario obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Listando Usuarios
        /// </summary>
        /// <returns>Listado de Usuario</returns>
        public IEnumerable<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                usuarios = (List<Usuario>)usuarioRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return usuarios;
        }
        /// <summary>
        /// Obteniendo Usuario
        /// </summary>
        /// <param name="id">identificador de Usuario</param>
        /// <returns>Usuario</returns>
        public Usuario GetOne(int id)
        {
            Usuario usuario = new Usuario();
            List<Perfil> perfils = new List<Perfil>();
            List<Permiso> permisos = new List<Permiso>();
            try
            {
                //Obtener Usuario
                usuario = usuarioRepository.GetOne(id);
                //Obtener Perfiles
                perfils = PerfilRelationship.GetPermisos(usuario);
                foreach (var item in perfils)
                {
                    usuario.Permisos.Add(item);
                }
                //Obtener Permisos
                permisos = PermisoRelationship.GetPermisos(usuario);
                foreach (var item in permisos)
                {
                    usuario.Permisos.Add(item);
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return usuario;
        }
        /// <summary>
        /// Registrando Usuario
        /// </summary>
        /// <param name="usuario">Usuario</param>
        public void insert(Usuario usuario)
        {
            Usuario usuarioid = new Usuario();
            try
            {
                usuario.Contraseña = EncryptPassword(usuario.Contraseña);
                usuarioRepository.Insert(usuario);
                usuarioid = usuarioRepository.GetId(usuario.usuario);
                usuario.IdUsuario = usuarioid.IdUsuario;
                foreach (var item in usuario.Permisos)
                {
                    if (item.Cantidad_de_permisos > 0)
                    {
                        Perfil perfil = new Perfil();
                        perfil = (Perfil)item;
                        PerfilRelationship.Join(perfil, usuario);
                    }
                    if(item.Cantidad_de_permisos == 0)
                    {
                        Permiso permiso = new Permiso();
                        permiso = (Permiso)item;
                        PermisoRelationship.Join(permiso, usuario);
                    }
                }
                
                    
               

            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Actulizando Usuario
        /// </summary>
        /// <param name="usuario">Usuario</param>
        public void update(Usuario usuario)
        {
            try
            {
                
                //Borrar Relaciones de Perfil y Permisos
                PerfilRelationship.DeleteJoin(usuario);
                PermisoRelationship.DeleteJoin(usuario);
                //Hacer update de Usuario
                if (usuario.Contraseña != null)
                {
                    usuario.Contraseña = EncryptPassword(usuario.Contraseña);
                    usuarioRepository.Cambiar_contraseña(usuario);
                }
                usuarioRepository.Update(usuario);
                //Creacion de relaciones con Perfil y Permiso
                foreach (var item in usuario.Permisos)
                {
                    if (item.Cantidad_de_permisos > 0)
                    {
                        Perfil perfil = new Perfil();
                        perfil = (Perfil)item;
                        PerfilRelationship.Join(perfil, usuario);
                    }
                    if (item.Cantidad_de_permisos == 0)
                    {
                        Permiso permiso = new Permiso();
                        permiso = (Permiso)item;
                        PermisoRelationship.Join(permiso, usuario);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Ingresando Al sistema con el Usuario
        /// </summary>
        /// <param name="usuario">Usuario</param>
        /// <returns>Aceptacion de Usuario o no</returns>
        public bool Login(Usuario usuario)
        {
            bool login = new bool();
            Usuario usuariologin = new Usuario();
            List<Perfil> perfils = new List<Perfil>();
            List<Permiso> permisos = new List<Permiso>();
            try
            {
                usuario.Contraseña = EncryptPassword(usuario.Contraseña);
                usuariologin = usuarioRepository.Login(usuario);
                
                if (usuariologin.IdUsuario != null)
                {
                    if(usuariologin.Habilitado == false)
                    {
                        throw new UsuarioInhabilitado();
                    }
                    else
                    {
                        login = true;
                        LoginCache.IdUsuario = (int)usuariologin.IdUsuario;
                        LoginCache.Usuario = usuariologin.usuario;
                        LoginCache.Habilitado = (bool)usuariologin.Habilitado;
                        perfils = PerfilRelationship.GetPermisos(usuariologin);
                        permisos = PermisoRelationship.GetPermisos(usuariologin);
                        foreach (var item in perfils)
                        {
                            LoginCache.Permisos.Add(item);
                        }
                        foreach (var item in permisos)
                        {
                            LoginCache.Permisos.Add(item);
                        }
                    }
                    
                }
                else
                {
                    login = false;
                    throw new LoginException();
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return login; 
        }
        /// <summary>
        /// Encriptado de contraseña
        /// </summary>
        /// <param name="Contraseña">Contraseña</param>
        /// <returns></returns>
        public static string EncryptPassword(string Contraseña)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(Contraseña));
                return Convert.ToBase64String(data);
            }
        }
    }
}
