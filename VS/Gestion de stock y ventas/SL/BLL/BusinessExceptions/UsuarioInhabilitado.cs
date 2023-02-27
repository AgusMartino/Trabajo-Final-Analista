using SL.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessExceptions
{
    public class UsuarioInhabilitado : BusinessException
    {
        public UsuarioInhabilitado() : base("El Usuario no esta Habilitado")
        {

        }
    }
}
