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
    internal class EmpleadoRepository : IGenericRepository<Empleado>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Empleado] (Nombre, Apellido, Dni, Fecha_de_nacimiento, Direccion) VALUES (@Nombre, @Apellido, @Dni, @Fecha_de_nacimiento, @Direccion)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Empleado] SET (Nombre = @Nombre, Apellido = @Apellido, Fecha_de_nacimiento = @Fecha_de_nacimiento, Direccion = @Direccion) WHERE Dni  = @Dni";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Empleado] WHERE Dni  = @Dni";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Empleado] WHERE Dni  = @Dni";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Empleado]";
        }
        #endregion

        public void delete(Empleado obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Empleado> GetAll()
        {
            List<Empleado> empleados = new List<Empleado>();
            Empleado empleado = default;
            
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo listado de Empleados", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        empleado = EmpleadoAdapter.Current.Adapt(values);
                        empleados.Add(empleado);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return empleados;
        }

        public Empleado GetOne(int id)
        {
            Empleado empleado = default;
            string statement = "SELECT * FROM [dbo].[Empleado] WHERE Id_empleado  = @Id_empleado";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo empleados con Id {id}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text,
                                new SqlParameter("@Id_empleado", id)))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        empleado = EmpleadoAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return empleado;
        }

        public Empleado GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Empleado GetOneDni(int Dni)
        {
            Empleado empleado = default;
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo empleados con Dni {Dni}", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                                new SqlParameter("@Dni", Dni)))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        empleado = EmpleadoAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return empleado;
        }

        public void import(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void insert(Empleado empleado)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Haciendo el alta del Empleado con Dni {empleado.Dni}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@Nombre", empleado.Nombre),
                                         new SqlParameter("@Apellido", empleado.Apellido),
                                         new SqlParameter("@Dni", empleado.Dni),
                                         new SqlParameter("@Fecha_de_nacimiento", empleado.Fecha_nacimiento),
                                         new SqlParameter("@Direccion", empleado.Direccion)});
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

        public void update(Empleado empleado)
        {
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Haciendo la actulizacion del Empleado con Dni {empleado.Dni}", EventLevel.Informational);
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@Nombre", empleado.Nombre),
                                         new SqlParameter("@Apellido", empleado.Apellido),
                                         new SqlParameter("@Dni", empleado.Dni),
                                         new SqlParameter("@Fecha_de_nacimiento", empleado.Fecha_nacimiento),
                                         new SqlParameter("@Direccion", empleado.Direccion)});
            }
            catch (Exception ex )
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public IEnumerable<int> ValidacionInt()
        {
            List<int> Dnis = new List<int>();
            int dni = 0;
            string statement = "SELECT Dni FROM [dbo].[Empleado]";
            try
            {
                SL.Services.LoggerManager.GetInstance().Write($"Obteniendo listado de DNI's de Empleados", EventLevel.Informational);
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        dni = int.Parse(values.ToString());
                        Dnis.Add(dni);
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return Dnis;
        }

        public IEnumerable<string> ValidacionString()
        {
            throw new NotImplementedException();
        }
    }
}
