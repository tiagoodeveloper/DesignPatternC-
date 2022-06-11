using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var mensagem = new MensagemCliente("Tiago");
            var enviador = new MensagemPorSMS
                ();

            mensagem.Enviador = enviador;
            mensagem.Envia();

        }
    }
}
