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
    class Perfil_PerfilRepository : IGenericRelationship<Perfil, Perfil>
    {
        public void DeleteJoin(Perfil obj)
        {
            string statement = "DELETE FROM [dbo].[Perfil_Perfil] WHERE IdPerfil = @IdPerfil";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Elimminando Relaciones de Perfiles con perfil {obj.Id}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(statement, System.Data.CommandType.Text, new SqlParameter("@IdPerfil", obj.Id));
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public List<Perfil> Get(Perfil obj)
        {
            List<Perfil> perfils = new List<Perfil>();
            Perfil perfil = new Perfil();
            try
            {
                string statements = "select Perfil.IdPerfil, Perfil.Perfil from Perfil left join Perfil_Perfil on Perfil_Perfil.IdPerfil_hijo = Perfil.IdPerfil where Perfil_Perfil.IdPerfil = @IdPerfil";
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Perfiles relacionados", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statements, System.Data.CommandType.Text, new SqlParameter[]
                {
                    new SqlParameter("@IdPerfil", obj.Id)
                }))
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

        public List<Perfil> GetPermisos(Perfil obj)
        {
            throw new NotImplementedException();
        }

        public void Join(Perfil perfilpadre, Perfil perfilHijo)
        {
            try
            {
                string statements = "INSERT INTO Perfil_Perfil(IdPerfil,IdPerfil_hijo) values (@IdPerfil, @IdPerfil_hijo)";
                SL.Services.LoggerManager.GetInstance().Write($"Creando relacion entre perfil y perfil", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(statements, System.Data.CommandType.Text, new SqlParameter[]
                {
                    new SqlParameter("@IdPerfil", perfilpadre.Id),
                    new SqlParameter("@IdPerfil_hijo", perfilHijo.Id)
                });
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
    }
}
