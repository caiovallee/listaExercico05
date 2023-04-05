using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class cilindro
    {
        internal double altura;
        internal double raio;

        internal double CalcularCilindro()
        {
            return Math.PI * (raio * raio) * altura;
        }
    }
}
