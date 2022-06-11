namespace Decorator
{
    public class Item
    {
        public double Valor { get; private set; }

        public string Nome { get; private set; }

        public Item(double valor, string nome)
        {
            this.Valor = valor;
            this.Nome = nome;
        }
    }
}
