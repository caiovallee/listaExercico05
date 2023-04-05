using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Volume_Esfera esfera = new Volume_Esfera();

            Console.WriteLine("digite o volume da esfera");
            esfera.raio = double.Parse(Console.ReadLine());

            Console.WriteLine("O volume da esfera é : " + esfera.CalcularVolume());
            Console.ReadLine();
        }
    }
}
