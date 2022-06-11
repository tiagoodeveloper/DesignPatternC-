using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Impressora
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            //Valor esquerda
            soma.Esquerda.Aceita(this);
            Console.Write("+");
            //Valor direita
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            //Valor esquerda
            subtracao.Esquerda.Aceita(this);
            Console.Write("-");
            //Valor direita
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }
    }
}
