using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class MensagemPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando por email");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
