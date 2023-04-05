using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Program
    {
        //Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius

        static void Main(string[] args)
        {
            Conversor_de_farenhart_para_celsius conversor = new Conversor_de_farenhart_para_celsius();
            Console.WriteLine("Insira a temperatura em fahrenheit a ser convertida");
            conversor.fahrenheit = double.Parse(Console.ReadLine());

            Console.WriteLine($"a temperatura convertida é " + conversor.CalcularConeversão());
            Console.ReadLine();



        }
    }
}
