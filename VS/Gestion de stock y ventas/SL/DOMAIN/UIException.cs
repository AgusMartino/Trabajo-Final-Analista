using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DOMAIN
{
    public class UIException : Exception
    {
        public UIException(String message) : base(message)
        {

        }
    }
}
