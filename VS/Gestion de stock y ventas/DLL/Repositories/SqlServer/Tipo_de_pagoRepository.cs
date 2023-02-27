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
    internal class Tipo_de_pagoRepository : IGenericRepository<Tipo_de_pago>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Tipo_de_pago] () VALUES ()";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Tipo_de_pago] SET () WHERE  = @";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Tipo_de_pago] WHERE  = @";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Tipo_de_pago] WHERE IdTipo_de_pago = @IdTipo_de_pago";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Tipo_de_pago]";
        }
        #endregion

        public void delete(Tipo_de_pago obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tipo_de_pago> GetAll()
        {
            List<Tipo_de_pago> tipo_De_Pagos = new List<Tipo_de_pago>();
            Tipo_de_pago tipo_De_Pago = new Tipo_de_pago();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Lista de tipos de pagos", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        tipo_De_Pago = Tipo_de_pagoAdapter.Current.Adapt(vs);
                        tipo_De_Pagos.Add(tipo_De_Pago);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return tipo_De_Pagos;
        }

        public Tipo_de_pago GetOne(int id)
        {
            Tipo_de_pago tipo_De_Pago = new Tipo_de_pago();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo tipo de pago con id {id}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text, new SqlParameter("@IdTipo_de_pago", id)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        tipo_De_Pago = Tipo_de_pagoAdapter.Current.Adapt(vs);
                    }
                }

            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return tipo_De_Pago;
        }

        public Tipo_de_pago GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Tipo_de_pago GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Tipo_de_pago obj)
        {
            throw new NotImplementedException();
        }

        public void Savechanges()
        {
            throw new NotImplementedException();
        }

        public void update(Tipo_de_pago obj)
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
