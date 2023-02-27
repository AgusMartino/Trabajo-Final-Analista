using SL.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.BusinessExceptions
{
    public class LoginException : BusinessException
    {
        public LoginException() : base("El Usuario o la contraseña es incorrecto")
        {

        }
    }
}
