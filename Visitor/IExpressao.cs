using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IExpressao
    {
        public int Avalia();

        public void Aceita(Impressora impressora);
    }
}
