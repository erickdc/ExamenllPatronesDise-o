using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenllPatronesDiseño.Component;

namespace ExamenllPatronesDiseño.Decorator
{
    public abstract class OperacionLog : Log
    {
        public Log LogItem { get; set; }
        public int Resultado { get; set; }
        public StreamWriter Escritor;
        private FileStream _archivo;

        public OperacionLog(Log logItem, int resultado)
        {
            CreateFile();
            Resultado=resultado;
            LogItem = logItem;
        }


        public void CreateFile()
        {
            if (File.Exists(NombreLog)) return;
            _archivo = new FileStream(NombreLog, FileMode.Create);
            _archivo.Close();
        }

        public void WriteToLog(string log)
        {
            Escritor = new StreamWriter(new FileStream(NombreLog, FileMode.Append));
            Escritor.WriteLine(log);
            Escritor.Close();
        }


    }
}
