using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaHarmonica harmonia = new MediaHarmonica();
            Console.WriteLine("Digite a nota 1");
            harmonia.nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2");
            harmonia.nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3");
            harmonia.nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine(" A media harmonica é de : " + harmonia.CalcularMedia());
            Console.ReadLine();
        }
    }
}
