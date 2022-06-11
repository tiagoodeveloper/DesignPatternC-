
namespace Facade
{
    class EmpresaFacade
    {
        public Cliente BuscaCliente(string cpf)
        {
            return new ClienteDAO().BuscarPorCpf("111-111-111-11");
        }

        public Fatura GeraFatura(Cliente cliente, double valor)
        {
            return new Fatura(cliente, valor);
        }
        public Cobranca GeraCobranca(Fatura fatura, TipoCobranca tipoCobranca)
        {
            return new Cobranca(tipoCobranca, fatura);
        } 
        public ContatoCliente GeraContatoCliente(Fatura fatura, Cliente cliente)
        {
            return new ContatoCliente(cliente, fatura);
        }
    }
}
