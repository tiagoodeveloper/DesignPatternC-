using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class MensagemPorSMS : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando por SMS");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
