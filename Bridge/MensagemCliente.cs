using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class MensagemCliente : IMensagem
    {

        public string Nome { get; private set; }
        public IEnviador Enviador { get; set; }

        public MensagemCliente(string nome)
        {
            this.Nome = nome;
        }
        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o cliente {0}", this.Nome);
        }
    }
}
