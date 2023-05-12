using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using abstracao.ClasseAbstrata;

namespace abstracao.ClasseDerivada
{
    public class Gato : Animal
    {
        public override void Comer(string comida)
        {
            Console.WriteLine($"O Gato está comendo {comida}");
        }

        public override string EmitirSom()
        {
            return "Miau...";
        }
    }
}