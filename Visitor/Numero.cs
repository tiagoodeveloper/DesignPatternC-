using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Numero : IExpressao
    {
        public int Valor { get; private set; }

        public Numero(int valor)
        {
            this.Valor = valor;
        }

        public void Aceita(Impressora impressora)
        {
            impressora.ImprimeNumero(this);
        }

        public int Avalia()
        {
            return this.Valor;
        }
    }
}
