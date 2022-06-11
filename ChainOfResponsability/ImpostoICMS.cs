namespace ChainOfResponsability
{
    public class ImpostoICMS : IImposto
    {
        public double RealizaCalculo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
