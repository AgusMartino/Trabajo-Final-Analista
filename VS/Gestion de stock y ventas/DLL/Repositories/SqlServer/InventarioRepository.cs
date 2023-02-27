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
    internal class InventarioRepository : IGenericRepository<Inventario>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Inventario] (IdMateriaPrima, Cantidad) VALUES (@IdMateriaPrima, @Cantidad)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Inventario] SET  Cantidad = @Cantidad WHERE IdInventario = @IdInventario";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Inventario] WHERE  IdInventario = @IdInventario";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Inventario] WHERE IdMateriaPrima = @IdMateriaPrima";
        }

        private string SelectAllStatement
        {
            get => "SELECT , IdInventario, IdMateriaPrima, Cantidad FROM [dbo].[Inventario]";
        }
        #endregion

        public void delete(Inventario obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inventario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Inventario GetOne(int id)
        {
            Inventario inventario = new Inventario();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Inventario de Materia Prima con id {id}", EventLevel.Informational);
                using(var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text, new SqlParameter("@IdMateriaPrima", id)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        inventario = InventarioAdapter.Current.Adapt(vs);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return inventario;
        }

        public Inventario GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Inventario GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Inventario inventario)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Generando Inventario de la Materia Prima con id {inventario.materiaPrima.IdMateriaPrima}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
                          new SqlParameter[] { new SqlParameter("@IdMateriaPrima", inventario.materiaPrima.IdMateriaPrima),
                                               new SqlParameter("@Cantidad", inventario.Cantidad)});
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public void Savechanges()
        {
            throw new NotImplementedException();
        }

        public void update(Inventario inventario)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Actualizando inventario de la Materia Prima con id {inventario.materiaPrima.IdMateriaPrima}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(UpdateStatement, System.Data.CommandType.Text,
                          new SqlParameter[] { new SqlParameter("@IdMateriaPrima", inventario.materiaPrima.IdMateriaPrima),
                                               new SqlParameter("@Cantidad", inventario.Cantidad),
                                               new SqlParameter("@IdInventario", inventario.IdInventario)});
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
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
