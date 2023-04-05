using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaOrientaçãoObJETOS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Caixa_Retangular caixa = new Caixa_Retangular();
            caixa.altura = 10;
            caixa.comprimento = 20;
            caixa.largura = 30;
            Console.WriteLine( "O volume da caixa é:" + caixa.CalcularVolume());
            Console.ReadLine();
        }
    }
}
