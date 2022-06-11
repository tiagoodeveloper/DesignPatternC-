using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    interface IEnviador
    {
        public void Envia(IMensagem mensagem);
    }
}
