using System;
using System.Collections.Generic;
using System.Text;

namespace Bridges
{
    class EnviaPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviado a mensagem por email");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
