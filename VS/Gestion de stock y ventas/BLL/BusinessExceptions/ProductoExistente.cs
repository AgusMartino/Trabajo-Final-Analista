using SL.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessExceptions
{
    public class ProductoExistente : BusinessException
    { 
        //Producto Existente
        public ProductoExistente() : base("El codigo de producto ya existe")
        {

        }
    }
}
