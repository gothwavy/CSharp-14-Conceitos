using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Abstracao
{
    abstract class Acoes
    {

        // Metodos obrigatorios
        public abstract void Falar();
        public abstract void Andar();

        // Metodos opcionais
        public void Pular()
        {
            Console.WriteLine("Estou pulando!");
        }

    }
}
