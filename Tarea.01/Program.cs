using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int novio, novia;
            int cal;
            Console.WriteLine("BIENVENIDO AL CALCULADOR DE EDADES");
            Console.WriteLine("Ingresa tu edad");
            novio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la edad de tu novia");
            novia = Convert.ToInt32(Console.ReadLine());
            cal = novio - novia;
            Console.WriteLine("LA DIFERENCIA DE EDAD ES DE: {0}", cal);
            /*
             * a
             * a
             * a
             * */
            Console.Read();
        }
        
    }
}
