using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(500);

            Console.WriteLine("Orçamento em aprovação:" + orcamento.Valor);

            orcamento.AplicaDescontoExtra();

            Console.WriteLine("Orçamento em aprovação com desconto:" + orcamento.Valor);

            orcamento.Aprova();

            orcamento.AplicaDescontoExtra();

            Console.WriteLine("Orçamento aprovado com desconto:" + orcamento.Valor);

            orcamento.Finaliza();

            //orcamento.AplicaDescontoExtra(); teste de  exception aqui

            Console.WriteLine("Orçamento finalizado em:" + orcamento.Valor);

            Console.ReadKey();
        }
    }
}

