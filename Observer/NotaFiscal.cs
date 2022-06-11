using System;
using System.Collections.Generic;

namespace Observer
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Observacao { get; set; }
        public List<ItemNota> ItensNota { get; set; }
        public double ValorTotal { get; set; }
        public double ValorImpostos { get; set; }
        public DateTime Data { get; set; }


        public NotaFiscal(string razaoSocial, string cnpj, string observacao, double valorTotal,
            double valorImpostos, List<ItemNota> itensNota, DateTime data)
        {
            this.RazaoSocial = razaoSocial;
            this.CNPJ = cnpj;
            this.Observacao = observacao;
            this.ItensNota = itensNota;
            this.ValorImpostos = valorImpostos;
            this.ValorTotal = valorTotal;
            this.Data = data;
        }
    }
}
