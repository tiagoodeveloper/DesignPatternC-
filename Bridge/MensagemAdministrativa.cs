using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class MensagemAdministrativa : IMensagem   
    {
        public string Nome { get; private set; }
        public IEnviador Enviador { get; set; }

        public MensagemAdministrativa(string nome)
        {
            this.Nome = nome;
        }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o administrador {0}", this.Nome);
        }
    }
}
