namespace State
{
    public class ImpostoIPP : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            foreach (var itemOrcamento in orcamento.Itens)
            {
                if (itemOrcamento.Valor > 100)
                    return true;
            }

            return false;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.5;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.02;
        }
    }
}
