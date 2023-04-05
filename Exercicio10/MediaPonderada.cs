using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class MediaPonderada
    {
        internal double nota1;
        internal double nota2;
        internal double peso1;
        internal double peso2;

        internal double CalcularMediaPonderada()
        {
            return (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
        }
    }
}
