using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Historico
    {
        public List<Estado> EstadosContrato { get; set; } = new List<Estado>();

        public void Adciona(Contrato contrato)
        {
            EstadosContrato.Add(new Estado(new Contrato(contrato.Data, contrato.Status, contrato.Interessado)));
        }
    }
}
