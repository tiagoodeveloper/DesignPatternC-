using System;

namespace Observer
{
    public class Reprovado : EstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Estado do orçamento não permite desconto!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Estado não permite Aprovar o orçamento!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Estado não permite Reprovar o orçamento!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Estado não permite Finalizar o orçamento!");
        }
    }
}
