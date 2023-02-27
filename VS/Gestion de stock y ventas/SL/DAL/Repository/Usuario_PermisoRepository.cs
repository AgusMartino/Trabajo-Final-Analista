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
    class Usuario_PermisoRepository : IGenericRelationship<Permiso, Usuario>
    {
        public void DeleteJoin(Usuario usuario)
        {
            string statement = "DELETE FROM [dbo].[Usuario_Permiso] WHERE IdUsuario = @IdUsuario";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Elimminando Relaciones de Permiso con Usuario {usuario.IdUsuario}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(statement, System.Data.CommandType.Text, new SqlParameter("@IdUsuario", usuario.IdUsuario));
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public List<Usuario> Get(Permiso obj)
        {
            throw new NotImplementedException();
        }

        public List<Permiso> GetPermisos(Usuario usuario)
        {
            List<Permiso> permisos = new List<Permiso>();
            Permiso permiso = new Permiso();
            string statement = "Select p.IdPermiso, p.Permiso, p.Vista from Usuario_Permiso up join Permiso p on p.IdPermiso = up.IdPermiso where up.IdUsuario = @IdUsuario";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Permisos relacionado con usuario {usuario.IdUsuario}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text, new SqlParameter("@IdUsuario", usuario.IdUsuario)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        permiso = PermisoAdapter.Current.Adapt(vs);
                        permisos.Add(permiso);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return permisos;
        }

        public void Join(Permiso obj1, Usuario obj2)
        {
            string statement = "INSERT INTO Usuario_Permiso(IdUsuario,IdPermiso) values (@IdUsuario, @IdPermiso)";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Realizando relacion entre Permiso y usuario", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(statement, System.Data.CommandType.Text, new SqlParameter[]
                {
                    new SqlParameter("@IdUsuario", obj2.IdUsuario),
                    new SqlParameter("@IdPermiso", obj1.Id)
                });
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
    }
}
