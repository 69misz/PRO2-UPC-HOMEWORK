using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion4
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0, valor2 = 0;
            string cadena;
            Console.WriteLine("Dame el primer valor:");
            cadena= Console.ReadLine();
            valor1 = Convert.ToInt32(cadena);
            Console.WriteLine("Dame el segundo valor:");
            cadena= Console.ReadLine();
            valor2 = Convert.ToInt32(cadena);
            if(valor1 <= valor2)
        

        }
    }
}