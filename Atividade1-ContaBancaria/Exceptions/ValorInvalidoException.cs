namespace Atividade1_ContaBancaria.Exceptions;

public class ValorInvalidoException : Exception
{
    public double Valor { get;}
    public ValorInvalidoException(string message , double valor) : base(message)
    {
        Valor = valor;

    }

}
