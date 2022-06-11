using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var notaFiscalBuilder = new NotaFiscalBuilder();

            notaFiscalBuilder
                .ComDataAtual()
                .ComEmpresa("Design Pattern Builder LTDA", "123.123.555/0001-55")
                .ComObservacao("Este builder é muito legal!")
                .ComItem(new ItemNota(100.0, "Street Fighter"))
                .ComItem(new ItemNota(150.0, "GTA V"));
            
            var notaFiscal = notaFiscalBuilder.Constroi();

            Console.WriteLine("Empresa: " + notaFiscal.CNPJ + " - " + notaFiscal.RazaoSocial);
            Console.WriteLine("Data: " + notaFiscal.Data);
            Console.WriteLine("Observação: " + notaFiscal.Observacao);
            Console.WriteLine("Valor total: " + notaFiscal.ValorTotal);
            Console.WriteLine("Valor impostos: " + notaFiscal.ValorImpostos);
            Console.WriteLine("Itens:");
            foreach (var ItemNota in notaFiscal.ItensNota)
            {
                Console.WriteLine("Nome: " + ItemNota.Nome );
                Console.WriteLine("Valor: " + ItemNota.Valor );
            }


            Console.ReadKey();
        }
    }
}

