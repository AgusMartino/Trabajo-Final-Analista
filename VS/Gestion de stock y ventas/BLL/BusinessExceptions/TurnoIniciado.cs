using SL.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessExceptions
{
    public class TurnoIniciado : BusinessException
    {
        //Turno Ya iniciado
        public TurnoIniciado() : base("Turno ya iniciado")
        {

        }
    }
}
