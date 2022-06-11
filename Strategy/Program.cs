using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var iis = new ImpostoIIS();
            var icms = new ImpostoICMS();
            var orcamento = new Orcamento(500.0);
            var calculadoraImposto = new CalculadoraImposto();

            calculadoraImposto.RealizaCalculo(orcamento, iis);
            calculadoraImposto.RealizaCalculo(orcamento, icms);
            Console.ReadKey();
        }
    }
}

