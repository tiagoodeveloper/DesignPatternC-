using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string CNPJ { get; private set; }
        public string Observacao { get; private set; }
        public List<ItemNota> ItensNota { get; private set; }
        public double ValorTotal { get; set; }
        public double ValorImpostos { get; set; }
        public DateTime Data { get; set; }

        public NotaFiscalBuilder()
        {
            ItensNota = new List<ItemNota>();
        }

        public NotaFiscalBuilder ComEmpresa(string razaoSocial, string cnpj)
        {
            this.RazaoSocial = razaoSocial;
            this.CNPJ = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacao(string observacao)
        {
            this.Observacao = observacao;
            return this;
        }

        public NotaFiscalBuilder ComDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemNota itemNota)
        {
            ItensNota.Add(itemNota);
            ValorTotal += itemNota.Valor;
            ValorImpostos += itemNota.Valor * 0.2;
            return this;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, CNPJ, Observacao, ValorTotal, ValorImpostos, ItensNota, Data);
        }
    }
}
