using System.Collections.Generic;

namespace State
{
    public class Orcamento
    {
        public double Valor { get; set; }

        public List<Item> Itens { get; set; }

        public EstadoOrcamento EstadoOrcamento { get; set; }
        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.EstadoOrcamento = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            EstadoOrcamento.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoOrcamento.Aprova(this);
        }

        public void Rerova()
        {
            EstadoOrcamento.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoOrcamento.Finaliza(this);
        }
    }
}
