using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            latadeoleo lata = new latadeoleo();
            lata.altura = 10;
            lata.raio = 20;

            Console.WriteLine("O raio da lata de oleo é: " + lata.CalcularVolume());
            Console.ReadLine();

        }
    }
}
