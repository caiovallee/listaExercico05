using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPonderada media = new MediaPonderada();
            Console.WriteLine("Digite a nota 1");
            media.nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2");
            media.nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o peso 1");
            media.peso1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o peso 2");
            media.peso2 = double.Parse(Console.ReadLine());

            Console.WriteLine("A media ponderada é : " + media.CalcularMediaPonderada());
            Console.ReadLine();
        }
    }
}
