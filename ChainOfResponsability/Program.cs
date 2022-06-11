using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(600.0);
            orcamento.Itens.Add(new Item(250, "GTA V"));
            orcamento.Itens.Add(new Item(150, "DEATH STRANDING"));
            orcamento.Itens.Add(new Item(150, "DEATH STRANDING"));
            orcamento.Itens.Add(new Item(150, "DEATH STRANDING"));
            //orcamento.Itens.Add(new Item(150, "DEATH STRANDING"));
            orcamento.Itens.Add(new Item(150, "DEATH STRANDING"));

            var calculadoraDesconto = new CalculadorDesconto();

            Console.WriteLine(calculadoraDesconto.CalculaDesconto(orcamento));

            
            Console.ReadKey();
        }
    }
}

