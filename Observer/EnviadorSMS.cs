using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class EnviadorSMS : AcaoAposConstruirNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("simulando envio de SMS");
        }
    }
}
