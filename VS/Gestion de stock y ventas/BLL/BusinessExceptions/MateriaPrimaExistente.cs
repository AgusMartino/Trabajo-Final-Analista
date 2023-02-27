using SL.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessExceptions
{
    public class MateriaPrimaExistente : BusinessException
    {
        //Materia Prima existente
        public MateriaPrimaExistente() : base("El codigo de Materia prima ya existe")
        {

        }
    }
}
