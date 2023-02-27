using SL.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessExceptions
{
    public class EmpleadoExistente : BusinessException
    {
        //Empleado Existente
        public EmpleadoExistente() : base("El Dni ya esta registrado")
        {


        }
    }
}
