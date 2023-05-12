using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace encapsulamento
{
    public class CartaodeCredito
    {
        public decimal ValorCredito { get; private set; }
        public int DiaVencimento { get; private set; }

        public CartaodeCredito(decimal ValorCredito, int DiaVencimento)
        {
            this.ValorCredito = ValorCredito;
            this.DiaVencimento = DiaVencimento;
        }

        public void AlterarDiaVencimento (int novoDia)
        {
            this.DiaVencimento = novoDia;
        }
    }
}