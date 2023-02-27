using SL.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessExceptions
{
    public class ClienteExistente : BusinessException
    {
        //Excepcion de cliente existente
        public ClienteExistente() : base("El Dni ya esta registrado")
        {

        }
    }
}
