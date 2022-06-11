using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();
            cliente.DataNascimento = new DateTime(2000, 01, 25);
            cliente.Endereco = "País: Brasil, Cidade: Florianopolis, Bairro: Centro, Rua: Beira Mar, Numero: 99999";
            cliente.Nome = "Tiago";

            Console.WriteLine(new GeradorXML().Gerar(cliente));
        }
    }
}
