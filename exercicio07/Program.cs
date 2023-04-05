using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario_vendedor salario = new Salario_vendedor();
            Console.WriteLine("Informe o salario base");
            salario.salarioBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a comisão");
            salario.comisão = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o total de vendas");
            salario.totalDeVendas = double.Parse(Console.ReadLine());


            Console.WriteLine("O salario final é de " + salario.CalcularSalarioFinal());
            Console.ReadLine();

        }
    }
}
