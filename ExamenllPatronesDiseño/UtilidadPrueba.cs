using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ExamenllPatronesDiseño
{
    class UtilidadPrueba
    {
        public static StreamReader Lector;

        public static int[] ConvertirDeTablaArregloEntero(Table table)
        {
            var resultado = new int[table.RowCount];
            for (int i = 0; i < table.RowCount; i++)
            {
                var row = table.Rows[i];
                resultado[i] = Convert.ToInt32(row["Resultado"]);
            }
            return resultado;
        }

        public static List<string> ListaDeOperaciones(Table table)
        {
            var listaLog=new List<string>();
            string line = "";
            for (int i = 0; i < table.RowCount; i++)
            {
                var row = table.Rows[i];
                line += row["Operacion"] + " ";
                line += row["Resultado"];
                listaLog.Add(line);
                line = "";
            }

            return listaLog;

        }

        public static List<string> DevolverListaLogs()
        {
            Lector = new StreamReader(new FileStream("Log.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite));
            string linea = "";
            var listaLogs = new List<string>();
            while (linea != null)
            {
                linea = Lector.ReadLine();

                if (linea != null)
                {
                    listaLogs.Add(linea);
                }

            }
            Lector.Close();


            var fileStream = new FileStream("Log.txt", FileMode.Truncate);
            fileStream.SetLength(0);
            fileStream.Close();
            return listaLogs;
        }
    }
}
