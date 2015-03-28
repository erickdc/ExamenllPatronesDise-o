using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

namespace ExamenllPatronesDiseño.Component
{
    public abstract class Log
    {

        public const string NombreLog = "Log.txt";
        public string LogMessage = "";
        public FileStream Archivo=null;
        public StreamWriter Escritor=null;
        public List<string> LogList=new List<string>();
        
        public void WriteToLogFile()
        {
            
        }
    }
}
