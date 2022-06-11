using System.Collections.Generic;
using System.Linq;

namespace Facade
{
    class ClienteDAO
    {
        public IList<Cliente> Clientes { get; set; } = new List<Cliente>()
        {
            new Cliente("Cliente 1", "111-111-111-11"),
            new Cliente("Cliente 2", "222-222-222-22"),
            new Cliente("Cliente 3", "333-333-333-33")
        };

        public Cliente BuscarPorCpf(string cpf)
        {
            return Clientes.FirstOrDefault(c => c.Cpf == cpf);
        }
    }
}
