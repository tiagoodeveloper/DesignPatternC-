namespace Observer
{
    public abstract class IImposto
    {
        public IImposto OutroImposto { get; set; }

        public IImposto(IImposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        public IImposto()
        {
            this.OutroImposto = null;
        }

        public abstract double RealizaCalculo(Orcamento orcamento);

        protected double CalculaOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) 
                return 0;

            return OutroImposto.RealizaCalculo(orcamento);
        }
    }
}
