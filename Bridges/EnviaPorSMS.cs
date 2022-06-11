using System;
using System.Collections.Generic;
using System.Text;

namespace Bridges
{
    class EnviaPorSMS : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviado a mensagem por SMS");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
