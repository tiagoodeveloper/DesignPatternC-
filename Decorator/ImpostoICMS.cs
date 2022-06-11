namespace Decorator
{
    public class ImpostoICMS : IImposto
    {
        

        public override double RealizaCalculo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
