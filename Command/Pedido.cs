using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Pedido
    {
        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        public StatusPedido Status { get; private set; }

        public Pedido(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Status = StatusPedido.Novo;
        }

        public void Paga()
        {
            this.Status = StatusPedido.Pago;
        }

        public void Finaliza()
        {
            this.Status = StatusPedido.Finalizado;
        }
    }
}


