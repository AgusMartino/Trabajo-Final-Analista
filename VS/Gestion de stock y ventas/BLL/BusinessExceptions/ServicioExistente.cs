using SL.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessExceptions
{
    public class ServicioExistente : BusinessException
    {
        //Servicio Existente
        public ServicioExistente() : base("El codigo del servicio ya existe")
        {

        }
    }
}
