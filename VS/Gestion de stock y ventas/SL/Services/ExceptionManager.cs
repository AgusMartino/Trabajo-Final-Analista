using SL.DOMAIN;
using SL.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Services
{
    public sealed class ExceptionManager
    {
        #region Singleton
        private readonly static ExceptionManager _instance = new ExceptionManager();

            public static ExceptionManager Current
            {
                get
                {
                    return _instance;
                }
            }

            private ExceptionManager()
            {
                //Implent here the initialization of your singleton
            }
        #endregion

        private string DALComponent = ConfigurationManager.AppSettings["DALComponent"];
        private string BLLComponent = ConfigurationManager.AppSettings["BLLComponent"];
        private string UIComponent = ConfigurationManager.AppSettings["UIComponent"];
        private string SLComponent = ConfigurationManager.AppSettings["SLComponent"];
        public void Handle(object sender, Exception ex)
        {
            string assemblyName = sender.GetType().Assembly.GetName().Name;
            if (assemblyName == UIComponent)
            {
                UIHandle(ex);
            }
            else if (assemblyName == BLLComponent)
            {
                BLLHandle(ex);
            }
            else if (assemblyName == DALComponent)
            {
                DALHandle(ex);
            }
            else if(assemblyName == SLComponent)
            {
                UIHandle(ex);
            }
            else
                throw new Exception("No se conoce el source para gestion de errores");
        }
        private void UIHandle(Exception ex)
        {
            if (ex.Source == "UI")
                WritePolicy(ex);
            if (ex.Source == "SL")
                WritePolicy(ex);
        }
        private void BLLHandle(Exception ex)
        {
            if (ex.InnerException != null)
            {
                throw new Exception("No se puede acceder al servidor de BD en este momento", ex);
            }
            else
            {
#pragma warning disable CS0184 // 'La expresión dada de la expresión "is" nunca tiene el tipo provisto
                if (ex is BusinessException)
#pragma warning restore CS0184 // 'La expresión dada de la expresión "is" nunca tiene el tipo provisto
                {
                    WritePolicy(ex);
                    throw ex;
                }
                else
                {
                    WritePolicy(ex);
                    throw new Exception("Ha ocurrido un error inesperado", ex);
                }
            }
        }
        private void DALHandle(Exception ex)
        {
            WritePolicy(ex);
            throw new Exception("DAL Execption", ex);
        }
        public void WritePolicy(Exception ex)
        {
            LoggerManager.GetInstance().Write($"Message: {ex.Message}, StackTrace: {ex.StackTrace}", System.Diagnostics.Tracing.EventLevel.Error);
        }
    }
}
