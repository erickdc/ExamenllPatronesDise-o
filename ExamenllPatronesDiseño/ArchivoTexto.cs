using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenllPatronesDiseño
{

    public class ArchivoTexto
    {
        public string NombreArchivo = "Operaciones.txt";
        public StreamReader Lector;
        public StreamWriter Escritor;
        private FileStream _archivo;
        public ArchivoTexto()
        {
            if (File.Exists(NombreArchivo)) return;
            _archivo = new FileStream(NombreArchivo, FileMode.Create);
            _archivo.Close();
        }

        public void EscribirComando(Comando operComando)
        {
            Escritor = new StreamWriter(new FileStream(NombreArchivo, FileMode.Append));
            Escritor.WriteLine(operComando.DevolverComoString());
            Escritor.Close();
        }

        public void EscribirListaComandos(List<Comando> comandos)
        {
            
            foreach (Comando t in comandos)
            {
                EscribirComando(t);
            }
        }

        public List<Comando> DevolverListaComandos()
        {
            Lector =new StreamReader(new FileStream(NombreArchivo, FileMode.OpenOrCreate, FileAccess.ReadWrite));
            string linea="";
            var listaComandos = new List<Comando>();
            while (linea != null)
            {
                linea = Lector.ReadLine();
                var operacion = new string[3];

                if (linea != null)
                {
                    operacion = linea.Split(null);
                    listaComandos.Add(new Comando((TipoOperacion)Enum.Parse(typeof(TipoOperacion),operacion[0]),
                                                    Convert.ToInt32(operacion[1]), 
                                                    Convert.ToInt32(operacion[2])));
                }
                    
            }
            return listaComandos;
        }
    }
}

 
