using BLL.Contracts;
using DLL.Contracts;
using DLL.Factories;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public sealed class TurnoService : IGenericBusinessLogic<Turno>
    {
        #region Singleton
        private readonly static TurnoService _instance = new TurnoService();

        public static TurnoService Current
        {
            get
            {
                return _instance;
            }
        }

        private TurnoService()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
        ITurnoRepository<Turno> turnoRepository = Factory.Current.GetTurnoRepository();
        /// <summary>
        /// Registrando turno
        /// </summary>
        /// <param name="turno">turno</param>
        public void insert(Turno turno)
        {
            try
            {
                turnoRepository.insert(turno);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Eliminando turno
        /// </summary>
        /// <param name="turno">turno</param>
        public void delete(Turno turno)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Actualizando Turno
        /// </summary>
        /// <param name="turno">Turno</param>
        public void update(Turno turno)
        {
            try
            {
                turnoRepository.update(turno);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
        /// <summary>
        /// Obteniendo Turno
        /// </summary>
        /// <param name="id">Identificador de turno</param>
        /// <returns>turno obtenido</returns>
        public Turno GetOne(int id)
        {
            Turno turno = new Turno();
            try
            {
                turno = turnoRepository.GetOne(id);
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return turno;
        }
        /// <summary>
        /// Listando turnos
        /// </summary>
        /// <returns>listado de turnos</returns>
        public IEnumerable<Turno> GetAll()
        {
            List<Turno> turnos = new List<Turno>();
            try
            {
                turnos = (List<Turno>)turnoRepository.GetAll();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
            return turnos;
        }
        /// <summary>
        /// Obteniendo identificador de turno
        /// </summary>
        /// <param name="dateTime">fecha de inicio de turno</param>
        public void GetTurno(DateTime dateTime)
        {
            Turno turno = new Turno();
            try
            {
                turno = turnoRepository.GetTurno(dateTime);
                TurnoIniciadoCache.IdTurno = turno.IdTurno;
                TurnoIniciadoCache.Fecha_de_inicio = turno.Fecha_de_inicio;
                TurnoIniciadoCache.Caja_inicial = turno.Caja_inicial;
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }

        public Turno GetOneCode(string code)
        {
            throw new NotImplementedException();
        }

        public Turno GetOneDni(int Dni)
        {
            throw new NotImplementedException();
        }

        public bool ValidacionString(string code)
        {
            throw new NotImplementedException();
        }

        public bool ValidacionInt(int Dni)
        {
            throw new NotImplementedException();
        }

        public void importMassive(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }

}
