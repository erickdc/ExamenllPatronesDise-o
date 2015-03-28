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
        public static int[] ConvertirDeTablaArregloEntero(Table table)
        {
            int[] resultado = new int[table.RowCount];
            for (int i = 0; i < table.RowCount; i++)
            {
                var row = table.Rows[i];
                resultado[i] = Convert.ToInt32(row["Resultado"]);
            }
            return resultado;
        }
    }
}
