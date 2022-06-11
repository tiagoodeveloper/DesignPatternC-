namespace Decorator
{
    public abstract class TemplateDeImpostoCondicional : IImposto
    {
        protected TemplateDeImpostoCondicional(IImposto outroImposto) : base(outroImposto)
        {
        }

        protected TemplateDeImpostoCondicional() : base()
        {
        }

        public override double RealizaCalculo(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
                return MaximaTaxacao(orcamento);
                
            return MinimaTaxacao(orcamento);
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
