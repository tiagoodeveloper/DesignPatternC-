using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //decorator
            ImpostoIIS impostoIIS = new ImpostoIIS(new ImpostoICMS());

            Orcamento orcamento = new Orcamento(500);

            double valor = impostoIIS.RealizaCalculo(orcamento);

            Console.WriteLine(valor);
        }
    }
}

