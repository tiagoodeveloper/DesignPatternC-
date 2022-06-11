using System;
using System.Collections.Generic;
using System.Text;

namespace Bridges
{
    interface IEnviador
    {
        public void Envia(IMensagem mensagem);
    }
}
