using System;
using ExamenllPatronesDiseño;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Log log = new OperadorLog();
            log = new MultiplicadorLog(log);
            log = new RestadorLog(log);

            Console.Write(log.LogList.ToArray());
        }
    }
}
