using System.Collections.Generic;

namespace FlyWeight
{
    public class NotasMusicais
    {
        

        private static IDictionary<string, INota> Notas =
            new Dictionary<string, INota>()
            {
                {"do", new Do() },
                {"re", new Re() },
                {"mi", new Mi() },
                {"fa", new Fa() },
                {"sol", new Sol() },
                {"la", new La() },
                {"si", new Si() }
            };

        public INota ObterNota(string nome)
        {
            return Notas[nome];
        }
    }
}
