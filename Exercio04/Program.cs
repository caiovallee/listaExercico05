using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Consumo_por_litro consumo = new Consumo_por_litro();

            Console.WriteLine("Digite a quilometragem inical");
            consumo.quilometragemInicial = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quilometragem final");
            consumo.quilometragemFinal = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de combustivel gasto");
            consumo.consumoCombustivel = double.Parse(Console.ReadLine());

            Console.WriteLine("O consumo por km é de : " + consumo.CalcularConsumoKm() + "L");
            Console.ReadLine();
        }
    }
}
