using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstracao.ClasseAbstrata
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract string EmitirSom();
        public abstract void Comer(string comida);
        public virtual void Correr()
        {
            Console.WriteLine("O animal está correndo..."); 
        }
    }
}