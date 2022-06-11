using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Estado
    {
        public DateTime DataHoraAlteracao { get; }

        public Contrato Contrato { get; }

        public Estado(Contrato contrato)
        {
            this.Contrato = contrato;
            this.DataHoraAlteracao = DateTime.Now;
        }
    }
}
