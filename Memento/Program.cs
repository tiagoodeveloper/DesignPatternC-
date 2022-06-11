using System;

namespace Memento
{
    class Program
    {
        /// <summary>
        /// adicionad dentro de estado para ter mais uma informação de data e hora de alteração.
        /// poderia apenas criar uma lista de contratos separada para armazenar o histórico
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var historico = new Historico();
            var contrato = new Contrato(DateTime.Now, EStatus.Novo, "Tiago");

            //Primeiro estado
            historico.Adciona(contrato);
            Console.WriteLine("Estado contrato 1" + contrato.Status);

            //Segundo estado
            contrato.Avanca();
            historico.Adciona(contrato);
            Console.WriteLine("Estado contrato 2" + contrato.Status);

            //Terceiro estado
            contrato.Avanca();
            historico.Adciona(contrato);
            Console.WriteLine("Estado contrato 3" + contrato.Status);
            
            Console.WriteLine("Histórico do estado do contrato 1" + historico.EstadosContrato[0].Contrato.Status);
            Console.WriteLine("Histórico do estado do contrato 2"+ historico.EstadosContrato[1].Contrato.Status);
            Console.WriteLine("Histórico do estado do contrato 3" + historico.EstadosContrato[2].Contrato.Status);

            Console.ReadKey();

        }
    }
}
