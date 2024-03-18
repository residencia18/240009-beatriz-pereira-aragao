using Atividade4_IServico.Interfaces;

namespace Atividade4_IServico.Entities;

public class ServicoFabrica<T> where T : IServico , new()
{
    public T NovaInstancia()
    {
        return new T();
    }

}
