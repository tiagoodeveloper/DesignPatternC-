using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var fila = new FilaPedido();
            var pedido1 = new Pedido("Tiago", 10.00);
            var pedido2 = new Pedido("Iara", 20.00);

            fila.AdicionaComando(new PagaPedido(pedido1));
            fila.AdicionaComando(new PagaPedido(pedido2));
            fila.AdicionaComando(new FinalizaPedido(pedido1));

            fila.ProcessaComandoEmPedidos();

        }
    }
}
