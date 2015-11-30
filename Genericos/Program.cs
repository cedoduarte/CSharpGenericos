using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            var valor1 = new Generico<int>();
            var valor2 = new Generico<string>();
            var valor3 = new Generico<double>();

            valor1.Valor = 5;
            valor2.Valor = "Hola, mundo!!!";
            valor3.Valor = 3.1416;

            valor1.Imprime();
            valor2.Imprime();
            valor3.Imprime();
            Console.Read();
        }
    }
}
