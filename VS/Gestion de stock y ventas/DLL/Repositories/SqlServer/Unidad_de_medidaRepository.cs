using DAL.Tools;
using DLL.Contracts;
using DLL.Repositories.SqlServer.Adapters;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories.SqlServer
{
    internal class Unidad_de_medidaRepository : IGenericRepository<Unidad_De_Medida>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Unidad_de_medida] () VALUES ()";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Unidad_de_medida] SET () WHERE  = @";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Unidad_de_medida] WHERE  = @";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Unidad_de_medida] WHERE Id_unidad_de_medida = @Id_unidad_de_medida";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Unidad_de_medida]";
        }
        #endregion

        public void delete(Unidad_De_Medida obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Unidad_De_Medida> GetAll()
        {
            List<Unidad_De_Medida> unidad_De_Medidas = new List<Unidad_De_Medida>();
            Unidad_De_Medida unidad_De_Medida = default;
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo listado de Unidad de medidas", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        unidad_De_Medida = UnidadDeMedidaAdapter.Current.Adapt(values);
                        unidad_De_Medidas.Add(unidad_De_Medida);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return unidad_De_Medidas;
        }

        public Unidad_De_Medida GetOne(int id)
        {
            Unidad_De_Medida unidad_De_Medida = default;
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Unidad de medida con id {id}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                                                        new SqlParameter("@Id_unidad_de_medida", id)))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        unidad_De_Medida = UnidadDeMedidaAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return unidad_De_Medida;
        }

        public Unidad_De_Medida GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Unidad_De_Medida GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Unidad_De_Medida obj)
        {
            throw new NotImplementedException();
        }

        public void Savechanges()
        {
            throw new NotImplementedException();
        }

        public void update(Unidad_De_Medida obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> ValidacionInt()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> ValidacionString()
        {
            throw new NotImplementedException();
        }
    }
}
