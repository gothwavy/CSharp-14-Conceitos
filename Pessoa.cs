using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Abstracao
{
    internal class Pessoa : Acoes
    {
        public override void Andar()
        {
            Console.WriteLine("Estou andando!");
        }

        public override void Falar()
        {
            Console.WriteLine("Estou falando!");
        }
    }
}
