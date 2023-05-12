using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using abstracao.ClasseAbstrata;

namespace abstracao.ClasseDerivada
{
    public class Cachorro : Animal
    {
        public override void Comer(string comida)
        {
            Console.WriteLine($"O Cachorro está comendo {comida}");
        }

        public override string EmitirSom()
        {
            return "Au au";
        }

        public override void Correr()
        {
            Console.WriteLine("O Cachorro está correndo!");
        }
    }
}