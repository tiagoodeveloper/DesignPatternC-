namespace State
{
    public class CalculadorDesconto
    {
        public double CalculaDesconto(Orcamento orcamento)
        {
            var d1 = new DescontoMaisCincoItens();
            var d2 = new DescontoMaisQuinhentosReais();
            var d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;

            return d1.Desconta(orcamento);
        }
    }
}
