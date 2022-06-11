using System;

namespace State
{
    public class EmAprovacao : EstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.05;
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoOrcamento = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoOrcamento = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Estado não permite finalizar o orçamento!");
        }
    }
}
