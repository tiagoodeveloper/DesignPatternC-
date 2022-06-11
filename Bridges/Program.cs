using System;

namespace Bridges
{
    class Program
    {
        static void Main(string[] args)
        {
            var mensagem = new MensagemAdministrativa("Tiago");
            var enviador = new EnviaPorSMS();
            mensagem.Enviador = enviador;
            mensagem.Envia();
        }
    }
}
