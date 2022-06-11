namespace Singleton
{
    class Cliente
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }

        public Cliente(string nome, string cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
        }
    }
}
