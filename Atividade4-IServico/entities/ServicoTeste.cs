using Atividade4_IServico.Interfaces;

namespace Atividade4_IServico.Entities;

public class ServicoTeste : IServico
{
 public void Executar()
    {
        System.Console.WriteLine("Executando Serviço de Teste");
    }

}
