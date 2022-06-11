using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Contrato
    {
        public DateTime Data { get; }

        public EStatus Status { get; private set; }

        public string Interessado { get;  }

        public Contrato(DateTime data, EStatus status, string interessado)
        {
            this.Data = data;
            this.Status = status;
            this.Interessado = interessado;
        }

        public void Avanca()
        {
            if (this.Status == EStatus.Novo) this.Status = EStatus.EmAndamento;
            else if (this.Status == EStatus.EmAndamento) this.Status = EStatus.Aprovado;

        }
    }
}
