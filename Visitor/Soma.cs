using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Soma : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }


        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public void Aceita(Impressora impressora)
        {
            impressora.ImprimeSoma(this);
        }

        public int Avalia()
        {
            int valorEsquerda = this.Esquerda.Avalia();
            int valorDireita = this.Direita.Avalia();
            
            return valorDireita + valorDireita;
        }
    }
}
