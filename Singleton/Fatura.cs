﻿namespace Singleton
{
    class Fatura
    {
        public Cliente Cliente { get; set; }
        public double Valor { get; set; }

        public Fatura(Cliente cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
        }
    }
}
