using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Numero : IExpressao
    {
        private int Valor;

        public Numero(int valor)
        {
            this.Valor = valor;
        }
        public int Avalia()
        {
            return this.Valor;
        }
    }
}
