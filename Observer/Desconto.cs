namespace Observer
{
    public interface Desconto
    {
        public Desconto Proximo { get; set; }
        double Desconta(Orcamento orcamento);
    }
}
