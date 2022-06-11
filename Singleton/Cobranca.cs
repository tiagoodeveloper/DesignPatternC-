namespace Singleton
{
    class Cobranca
    {
        public TipoCobranca Tipo { get; set; }

        public Fatura Fatura { get; set; }

        public Cobranca(TipoCobranca tipo, Fatura fatura)
        {
            this.Tipo = tipo;
            this.Fatura = fatura;
        }

        public void Emite()
        {
            //TODO
        }
    }
}
