using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ExamenllPatronesDiseño
{
    class UtilidadPrueba
    {
        public static int[] ConvertirDeTablaResultadoArregloEntero(Table table)
        {
            int[] resultado = new int[table.RowCount];
            for (int i = 0; i < table.RowCount; i++)
            {
                var row = table.Rows[i];
                resultado[i] = Convert.ToInt32(row["Resultado"]);
            }
            return resultado;
        }
        public static List<Comando> ConvertirDeTablaListaComandos(Table table)
        {
            var resultado = new List<Comando>();
            for (int i = 0; i < table.RowCount; i++)
            {
                var row = table.Rows[i];
                resultado.Add(new Comando((TipoOperacion) Enum.Parse(typeof (TipoOperacion),row["Operacion"],true),Convert.ToInt32(row["Operando1"]),Convert.ToInt32(row["Operando2"])));
            }
            return resultado;
        }
    }
}
