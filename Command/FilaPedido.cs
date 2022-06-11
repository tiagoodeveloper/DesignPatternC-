using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class FilaPedido
    {
        IList<IComando> Comandos { get; set; } = new List<IComando>();

        public void ProcessaComandoEmPedidos()
        {
            foreach (var comando in Comandos)
            {
                comando.Executa();
            }
        }

        public void AdicionaComando(IComando comando)
        {
            Comandos.Add(comando);
        }
    }
}
