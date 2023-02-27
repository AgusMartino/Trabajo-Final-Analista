using SL.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessExceptions
{
    public class TurnoNoIniciado : BusinessException
    {
        //Turno no iniciado
        public TurnoNoIniciado() : base("Turno no iniciado")
        {

        }
    }
}
