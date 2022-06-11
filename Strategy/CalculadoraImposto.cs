using System;

namespace Strategy
{
    public class CalculadoraImposto
    {
        //WRONG
        //public void RealizaCalculo(Orcamento orcamento, String imposto)
        //{
        //    if ("IIS".Equals(imposto))
        //    {
        //        Console.WriteLine(orcamento.Valor * 0.06);
        //    }

        //    if ("ICMLS".Equals(imposto))
        //    {
        //        Console.WriteLine(orcamento.Valor * 0.1);
        //    }
        //}


        //RIGHT
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            Console.WriteLine(imposto.RealizaCalculo(orcamento));
        }
    }
}
