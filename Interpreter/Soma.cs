using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Soma : IExpressao
    {
        public IExpressao Esquerda;
        public IExpressao Direita;


        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = this.Esquerda.Avalia();
            int valorDireita = this.Direita.Avalia();
            
            return valorDireita + valorDireita;
        }
    }
}
