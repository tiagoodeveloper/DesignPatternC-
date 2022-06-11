using System;

namespace Builder
{
    public class Aprovado : EstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.02;
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
            orcamento.EstadoOrcamento = new Finalizado();
        }
    }
}
