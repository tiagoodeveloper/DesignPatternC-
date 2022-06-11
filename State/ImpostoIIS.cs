using System;

namespace State
{
    public class ImpostoIIS : IImposto
    {
        public ImpostoIIS(IImposto outroImposto) : base(outroImposto)
        {
        }

        public ImpostoIIS() : base()
        {
        }

        public override double RealizaCalculo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculaOutroImposto(orcamento);
        }

        
    }
}
