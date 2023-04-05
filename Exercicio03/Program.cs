using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cilindro cilindrico = new cilindro();

            cilindrico.altura = 30.5;
            cilindrico.raio = 20.8;

            Console.WriteLine("O volumo do cilindo é " + cilindrico.CalcularCilindro());
            Console.ReadLine();


        }
    }
}
