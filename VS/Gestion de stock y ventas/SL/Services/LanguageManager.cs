using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SL.Services
{
   internal sealed class LanguageManager
    {
        #region Singleton
        private readonly static LanguageManager _instance = new LanguageManager();

            public static LanguageManager Current
            {
                get
                {
                    return _instance;
                }
            }

            private LanguageManager()
            {
                filePath = ConfigurationManager.AppSettings["Traducir"];
            }
        #endregion

        private string filePath = String.Empty;
        public string Translate(string Key)
        {
            // si no encuentra la traduccion devuelve la palabra original
            string traslateWord = Key;
            //optiene el codigo de cultura del dispositivo
            string culturaCodigo = Thread.CurrentThread.CurrentUICulture.Name;
            //Leo archivo de traduccion
            using (StreamReader streamReader = new StreamReader(filePath + culturaCodigo))
            {

                while (!streamReader.EndOfStream)
                {
                    // se asigna lo leido a una linea
                    string linea = streamReader.ReadLine();
                    //asigna la linea a un vector
                    string[] keyValuePair = linea.Split(':');

                    if (keyValuePair[0].ToLower() == Key.ToLower())
                    {
                        //en caso de ser la misma palabra, hace el intercambio
                        traslateWord = keyValuePair[1];
                        break;
                    }
                }
            }
            if (traslateWord == Key)
            {
                if (culturaCodigo != "es-AR")
                {
                    LoggerManager.GetInstance().Write($"No se pudo traducir la palabra {Key}", EventLevel.Verbose);
                }
            }
            return traslateWord;
        }


    }
}
