using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SL.Services
{
    public sealed class Helper
    {
        private readonly static Helper _instance = new Helper();

        public static Helper Current
        {
            get
            {
                return _instance;
            }
        }

        private Helper()
        {
            //Implent here the initialization of your singleton
        }
        /// <summary>
        /// instanciando Manual de usuario
        /// </summary>
        /// <param name="key">identificador de hoja</param>
        /// <param name="helpProvider">objeto</param>
        /// <param name="form">formulario</param>
        public void GetHelper(string key, HelpProvider helpProvider, Form form)
        {
            helpProvider.HelpNamespace = ConfigurationManager.ConnectionStrings["Helper"].ConnectionString;
            helpProvider.SetHelpKeyword(form, key);
            helpProvider.SetHelpNavigator(form, HelpNavigator.TopicId);
        }
    }

}
