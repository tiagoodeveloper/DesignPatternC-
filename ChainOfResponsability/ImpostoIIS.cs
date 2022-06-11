namespace ChainOfResponsability
{
    public class ImpostoIIS : IImposto
    {
        public double RealizaCalculo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
