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
    public class PermisoRepository : IGenericRepository<Permiso>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Permiso] (Nombre) VALUES (@Nombre)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Permiso] SET Nombre = @Nombre  WHERE IdPermiso = @IdPermiso";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Permiso] WHERE IdPermiso = @IdPermiso";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Permiso] WHERE IdPermiso = @IdPermiso";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Permiso]";
        }
        #endregion

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Permiso> GetAll()
        {
            List<Permiso> permisos = new List<Permiso>();
            Permiso permiso = new Permiso();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Lista de Permisos", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
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

        public Permiso GetId(string Nombre)
        {
            throw new NotImplementedException();
        }

        public Permiso GetOne(int id)
        {
            Permiso permiso = new Permiso();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Permiso con id{id}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text, new SqlParameter("@IdPermiso", id)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        permiso = PermisoAdapter.Current.Adapt(vs);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return permiso;
        }

        public void Insert(Permiso obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Permiso obj)
        {
            throw new NotImplementedException();
        }
    }
}
