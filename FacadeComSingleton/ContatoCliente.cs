namespace Facade
{
    class ContatoCliente
    {
        public Cliente Cliente { get; set; }

        public Fatura Fatura { get; set; }

        public ContatoCliente(Cliente cliente, Fatura fatura)
        {
            this.Cliente = cliente;
            this.Fatura = fatura;
        }
    }
}
