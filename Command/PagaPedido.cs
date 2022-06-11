using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class PagaPedido : IComando
    {
        private Pedido Pedido;

        public PagaPedido(Pedido pedido)
        {
            this.Pedido = pedido;
        }
        public void Executa()
        {
            Console.WriteLine("Pagando pedido para o cliente {0}", this.Pedido.Cliente);
            this.Pedido.Paga();
        }
    }
}
