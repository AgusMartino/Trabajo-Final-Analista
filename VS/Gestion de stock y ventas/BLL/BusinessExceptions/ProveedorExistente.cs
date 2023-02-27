using SL.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessExceptions
{
    public class ProveedorExistente : BusinessException
    {
        //Proveedor Existente
        public ProveedorExistente() : base("El cuit del proveedor ya esta registrado")
        {

        }
    }
}
