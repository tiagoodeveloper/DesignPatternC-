using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class NotaFiscalDao : AcaoAposConstruirNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("simulando persistência");
        }
    }
}
