using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    internal class MediaHarmonica
    {
        internal double nota1;
        internal double nota2;
        internal double nota3;

        internal double CalcularMedia()
        {
            return 3 / (1 / nota1 + 1 / nota2  +1 / nota3);
        }
    }
}
