namespace Atividade1_ContaBancaria.Exceptions;

public class SaldoInsuficienteException : Exception
{
    public double Valor { get; }
    public SaldoInsuficienteException(string message, double valor) : base(message)
    {
        Valor = valor;

    }
}
