using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class FinalizaPedido : IComando
    {
        private Pedido Pedido;
        public FinalizaPedido(Pedido pedido)
        {
            this.Pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Finalizando pedido para o cliente {0}", this.Pedido.Cliente);
            this.Pedido.Paga();
        }
    }
}
