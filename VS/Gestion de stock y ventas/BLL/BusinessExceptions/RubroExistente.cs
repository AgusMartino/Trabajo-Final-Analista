using SL.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessExceptions
{
    public class RubroExistente : BusinessException
    {
        //Rubro existente
        public RubroExistente() : base("El codigo del rubro ya existe")
        {

        }
    }
}
