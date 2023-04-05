using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class Conversor_Celsius
    {
        internal double celsius;

        internal double CalcularConversão()
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
