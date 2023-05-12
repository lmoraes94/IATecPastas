using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca.classeBase
{
    public class meioDeTransporte
    {
        public int CapacidadeMax { get; set; }

        public void Locomover()
        {
            Console.WriteLine("O objeto está se locomovendo");
        }
    }
}