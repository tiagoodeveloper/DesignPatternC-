using System.Collections.Generic;

namespace TemplateMethod
{
    public class Orcamento
    {
        public double Valor { get; set; }

        public List<Item> Itens { get; set; }
        public Orcamento(double valor)
        {
            this.Valor = valor;
            Itens = new List<Item>();
        }
    }
}
