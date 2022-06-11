using System;

namespace Observer
{
    public class EnviadorEmail : AcaoAposConstruirNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("simulando envio de email");
        }
    }
}
