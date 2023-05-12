using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace polimorfismo.Inteface
{
    public interface ImeioTransporte
    {
         void Locomover();
         void Abastecer(int qntd);
         bool EstaParado();
         bool PrecisaAbastecer();   
        
    }
}