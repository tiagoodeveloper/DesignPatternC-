namespace Bridge
{
    interface IMensagem
    {
        IEnviador Enviador { get; set; }
        void Envia();

        string Formata();
        
    }
}
