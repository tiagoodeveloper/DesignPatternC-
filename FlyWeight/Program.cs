using System;
using System.Collections.Generic;

namespace FlyWeight
{
    class Program
    {
        /// <summary>
        /// Ao invés de instanciar o fa várias vezes posso utilizar a mesma instancia de fa da classe notas
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //new List<INota>()
            //{
            //    new Do(), new Re(), new Mi(), new Fa(), new Fa(), new Fa()
            //};

            var notas = new NotasMusicais();
            var musica = new List<INota>()
            {
                notas.ObterNota("do"),
                notas.ObterNota("re"),
                notas.ObterNota("mi"),
                notas.ObterNota("fa"),
                notas.ObterNota("fa"),
                notas.ObterNota("fa")
            };

            var piano = new Piano();
            piano.Toca(musica);

        }
    }
}
