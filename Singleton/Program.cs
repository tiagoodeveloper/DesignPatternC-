using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            //var cliente = new ClienteDAO().BuscarPorCpf("111-111-111-11");
            //var fatura = new Fatura(cliente, 100.00);
            //var cobranca = new Cobranca(TipoCobranca.Pix, fatura);
            //cobranca.Emite();
            //var ContatoCliente = new ContatoCliente(cliente, fatura);


            //FACADE ESCONDENDO A COMPLEXDADE ACIMA EM UMA CLASSE EMPRESA FACADE
            //COM SINGLETON NÃO HÁ A NECESSIDADE DE FICAR INSTANCIANDO VÁRIAS VEZES
            //CRIAR UMA INSTANCIA E UTILIZAR EM TODA APLICAÇÃO
            var empresaFacade = new EmpresaFacadeSingleton().Instancia;
            var cliente = empresaFacade.BuscaCliente("111-111-111-11");
            var fatura = empresaFacade.GeraFatura(cliente, 10.00);
            var cobranca = empresaFacade.GeraCobranca(fatura, TipoCobranca.Pix);
            cobranca.Emite();
            var contatoCliente = empresaFacade.GeraContatoCliente(fatura, cliente);

        }
    }
}
