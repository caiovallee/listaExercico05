using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio07
{
    internal class Salario_vendedor
    {
        internal double comisão;
        internal double salarioBase;
        internal double totalDeVendas;

        internal double CalcularSalarioFinal()
        {
            return salarioBase + (totalDeVendas * comisão / 100);
        }
    }
}
