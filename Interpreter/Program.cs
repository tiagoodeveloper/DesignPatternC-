using System;
using System.Linq.Expressions;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var esquerda = new Soma(new Soma(new Numero(1), new Numero(10)), new Numero(20));
            var direita = new Subtracao(new Soma(new Numero(1), new Numero(10)), new Numero(5));
            var soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());
            Console.Write("pode-se usar a própria expression do c#´conforme a seguir:");

            var somaCSharp = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            Func<int>  resultCSharp = Expression.Lambda<Func<int>>(somaCSharp).Compile();

            Console.WriteLine(resultCSharp());
            Console.ReadKey();
        }
    }
}
