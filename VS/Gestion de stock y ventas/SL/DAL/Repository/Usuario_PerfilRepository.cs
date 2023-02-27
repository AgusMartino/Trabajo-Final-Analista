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
    class Usuario_PerfilRepository : IGenericRelationship<Perfil, Usuario>
    {
        public void DeleteJoin(Usuario usuario)
        {
            string statement = "DELETE FROM [dbo].[Usuario_Perfil] WHERE IdUsuario = @IdUsuario";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Elimminando Relaciones de Perfiles con Usuario {usuario.IdUsuario}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(statement, System.Data.CommandType.Text, new SqlParameter("@IdUsuario", usuario.IdUsuario));
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public List<Usuario> Get(Perfil obj)
        {
            throw new NotImplementedException();
        }

        public List<Perfil> GetPermisos(Usuario usuario)
        {
            List<Perfil> perfils = new List<Perfil>();
            Perfil perfil = new Perfil();
            string statement = "Select p.IdPerfil, p.Perfil from Usuario_Perfil up join Perfil p on p.IdPerfil = up.IdPerfil where up.IdUsuario = @IdUsuario";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Perfiles relacionado con usuario {usuario.IdUsuario}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text, new SqlParameter("@IdUsuario", usuario.IdUsuario)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        perfil = PerfilAdapter.Current.Adapt(vs);
                        perfils.Add(perfil);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return perfils;
        }

        public void Join(Perfil obj1, Usuario obj2)
        {
            string statement = "INSERT INTO Usuario_Perfil(IdUsuario,IdPerfil) values (@IdUsuario, @IdPerfil)";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Realizando relacion entre Perfil y usuario", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(statement, System.Data.CommandType.Text, new SqlParameter[]
                {
                    new SqlParameter("@IdUsuario", obj2.IdUsuario),
                    new SqlParameter("@IdPerfil", obj1.Id)
                });
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
    }
}
