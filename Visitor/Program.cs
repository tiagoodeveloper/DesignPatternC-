using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var esquerda = new Soma(new Soma(new Numero(1), new Numero(10)), new Numero(20));
            var direita = new Subtracao(new Soma(new Numero(1), new Numero(10)), new Numero(5));
            var soma = new Soma(esquerda, direita);
            var impressora = new Impressora();

            impressora.ImprimeSoma(soma);
            Console.ReadKey();
        }
    }
}
