using DLL.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories.SqlServer.Adapters
{
    public sealed class TurnoAdapter : IEntityAdapter<Turno>
    {
        #region Singleton
        private readonly static TurnoAdapter _instance = new TurnoAdapter();

        public static TurnoAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private TurnoAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public Turno Adapt(object[] values)
        {
            if(values[3] == DBNull.Value)
            {
                values[3] = null;
            }
            return new Turno
            {
                IdTurno = int.Parse(values[(int)Columns.IdTurno].ToString()),
                Caja_inicial = decimal.Parse(values[(int)Columns.CajaInicial].ToString()),
                Fecha_de_inicio = DateTime.Parse(values[(int)Columns.Fecha_de_inicio].ToString()),
                Fecha_de_cierre = Convert.ToDateTime(values[(int)Columns.Fecha_de_cierre])
            };
        }

        private enum Columns
        {
            IdTurno,
            CajaInicial,
            Fecha_de_inicio,
            Fecha_de_cierre
        }
    }

}
