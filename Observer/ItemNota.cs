using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class ItemNota
    {
        public double Valor { get; set; }
        public string Nome { get; set; }

        public ItemNota(double valor, string nome)
        {
            this.Valor = valor;
            this.Nome = nome;
        }
    }
}
