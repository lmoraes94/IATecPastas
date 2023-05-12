using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using polimorfismo.Inteface;

namespace polimorfismo.classesDerivadas
{
    public class Navio : ImeioTransporte

    {
        public int qntdCombustivel { get; set; }
        public int Velocidade { get; set; }
        public void Abastecer(int qntd)
        {
            qntdCombustivel = qntdCombustivel + qntd;
        }

        public bool EstaParado()
        {
            if (Velocidade == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Locomover()
        {
            Console.WriteLine("Navegando...");
        }

        public bool PrecisaAbastecer()
        {
            if (qntdCombustivel == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}