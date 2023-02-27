using DAL.Tools;
using DLL.Contracts;
using DLL.Repositories.SqlServer.Adapters;
using DOMAIN.Productos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories.SqlServer.Productos
{
    public class MateriaPrimaRepository : IGenericRepository<MateriaPrima>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Materia_Prima] (Id_unidad_de_medida,codigo_materiaprima, Nombre, Costo) VALUES (@Id_unidad_de_medida, @codigo_materiaprima, @Nombre, @Costo)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Materia_Prima] SET (Nombre = @Nombre, codigo_materiaprima = @codigo_materiaprima, Costo = @Costo, Id_unidad_de_medida = @Id_unidad_de_medida) WHERE Id_materiaprima = @Id_materiaprima";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Materia_Prima] WHERE Id_materiaprima = @Id_materiaprima";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Materia_Prima] WHERE Id_materiaprima = @Id_materiaprima";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Materia_Prima]";
        }
        #endregion

        public void delete(MateriaPrima obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MateriaPrima> GetAll()
        {
            List<MateriaPrima> materiaPrimas = new List<MateriaPrima>();
            MateriaPrima materiaPrima = default;
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo listado de materias primas", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        materiaPrima = MateriaPrimaAdapter.Current.Adapt(values);
                        materiaPrimas.Add(materiaPrima);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return materiaPrimas;
        }

        public MateriaPrima GetOne(int id)
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo materia prima con id {id}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text, new SqlParameter("@Id_materiaprima", id)))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        materiaPrima = MateriaPrimaAdapter.Current.Adapt(vs);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return materiaPrima;
        }

        public MateriaPrima GetOneCode(string code)
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            string statement = "SELECT * FROM [dbo].[Materia_Prima] WHERE codigo_materiaprima = @codigo_materiaprima";
            try
            {
                using(var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text,
                                                       new SqlParameter("@codigo_materiaprima", code)))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        materiaPrima = MateriaPrimaAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return materiaPrima;
        }

        public MateriaPrima GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(MateriaPrima materia)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Haciendo el Alta de la Materia Prima {materia.Codigo}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@Nombre", materia.Nombre), 
                                         new SqlParameter("@CodigoMateriaPrima", materia.Codigo),
                                         new SqlParameter("@Costo", materia.Costo),
                                         new SqlParameter("@IdUnidad_de_medida", materia.unidad_de_medida.idUnindad_de_medida)});
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

        public void update(MateriaPrima materia)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Haciendo la actulizacion de la Materia Prima {materia.Codigo}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(UpdateStatement, System.Data.CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@Nombre", materia.Nombre),
                                         new SqlParameter("@CodigoMateriaPrima", materia.Codigo),
                                         new SqlParameter("@Costo", materia.Costo),
                                         new SqlParameter("@IdMateriaPrima", materia.IdMateriaPrima),
                                         new SqlParameter("@IdUnidad_de_medida", materia.unidad_de_medida.idUnindad_de_medida)});
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
            List<string> Codes = new List<string>();
            string Code = "";
            string statement = "SELECT codigo_materiaprima FROM [dbo].[Materia_Prima]";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo Listado de Codigos de Materias Primas", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] vs = new object[dr.FieldCount];
                        dr.GetValues(vs);
                        Code = vs.ToString();
                        Codes.Add(Code);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return Codes;
        }
    }
}
