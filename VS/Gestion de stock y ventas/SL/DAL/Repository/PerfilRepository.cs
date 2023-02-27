
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
    public class PerfilRepository : IGenericRepository<Perfil>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Perfil] (Perfil) VALUES (@Nombre)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Perfil] SET Perfil = @Perfil WHERE IdPerfil = @IdPerfil";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Perfil] WHERE IdPerfil = @IdPerfil";
        }

        private string SelectOneStatement
        {
            get => "SELECT *  FROM [dbo].[Perfil] WHERE IdPerfil = @IdPerfil";
        }

        private string SelectAllStatement
        {
            get => "SELECT *  FROM [dbo].[Perfil]";
        }
        #endregion

        public void Delete(int id)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Elimminando Perfil con id", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(DeleteStatement, System.Data.CommandType.Text, new SqlParameter("@IdPerfil", id));
            }
            catch (Exception ex)
            {

                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public IEnumerable<Perfil> GetAll()
        {
            List<Perfil> perfils = new List<Perfil>();
            Perfil perfil = new Perfil();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Lista de Perfiles", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
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

        public Perfil GetId(string Nombre)
        {
            Perfil perfil = new Perfil();
            string statement = "Select * from Perfil where Perfil = @Perfil";
            try
            {
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text, new SqlParameter("@Perfil", Nombre)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        perfil = PerfilAdapter.Current.Adapt(vs);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return perfil;
        }

        public Perfil GetOne(int id)
        {
            Perfil perfil = new Perfil();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Perfil con id {id}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text, new SqlParameter("@IdPerfil", id)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        perfil = PerfilAdapter.Current.Adapt(vs);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return perfil;
        }

        public void Insert(Perfil perfil)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Realizando creacion del perfil {perfil.Id}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
                          new SqlParameter[] { new SqlParameter("@Nombre", perfil.Nombre) });
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public void Update(Perfil perfil)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Actualizando perfil con id {perfil.Id}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(UpdateStatement, System.Data.CommandType.Text,
                          new SqlParameter[] { new SqlParameter("@Perfil", perfil.Nombre),
                                               new SqlParameter("@IdPerfil", perfil.Id)});
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
    }
}
