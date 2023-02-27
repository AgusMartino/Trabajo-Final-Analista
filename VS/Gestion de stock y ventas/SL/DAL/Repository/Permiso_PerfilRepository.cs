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
    class Permiso_PerfilRepository : IGenericRelationship<Permiso, Perfil>
    {
        public void DeleteJoin(Perfil obj)
        {
            string statement = "DELETE FROM [dbo].[Permiso_Perfil] WHERE IdPerfil = @IdPerfil";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Elimminando Relaciones de permisos con perfil {obj.Id}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(statement, System.Data.CommandType.Text, new SqlParameter("@IdPerfil", obj.Id));
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public List<Perfil> Get(Permiso obj)
        {
            throw new NotImplementedException();
        }

        public List<Permiso> GetPermisos(Perfil perfil)
        {
            
            List<Permiso> permisos = new List<Permiso>();
            Permiso permiso = new Permiso();
            string statements = "Select p.IdPermiso, p.Permiso, p.Vista from Permiso p join Permiso_Perfil pp on pp.IdPermiso = p.IdPermiso where pp.IdPerfil = @IdPerfil";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo permisos del perfil con id {perfil.Id}", EventLevel.Informational);
                using(var dr = SqlHelper.ExecuteReader(statements, System.Data.CommandType.Text, new SqlParameter("@IdPerfil", perfil.Id)))
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

        public void Join(Permiso permiso, Perfil perfil)
        {
            try
            {
                string statements = "INSERT INTO Permisos_Perfil(IdPerfil,IdPermiso) values (@IdPerfil, @IdPermiso)";
                SL.Services.LoggerManager.GetInstance().Write($"Creando relacion entre perfil y permiso", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(statements, System.Data.CommandType.Text, new SqlParameter[] {new SqlParameter("@IdPerfil", perfil.Id),
                                                                                                        new SqlParameter("@IdPermiso", permiso.Id)});
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
    }
}
