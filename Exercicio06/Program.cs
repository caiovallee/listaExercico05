using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Conversor_Celsius conversor = new Conversor_Celsius();

            Console.WriteLine("Digite a temperatura celsius para ser convertida");
            conversor.celsius = double.Parse(Console.ReadLine());

            Console.WriteLine("A temperatura convertida para Farenhart é : " + conversor.CalcularConversão());
            Console.ReadLine();
        }
    }
}
