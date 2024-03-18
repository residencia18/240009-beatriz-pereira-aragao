using Atividade1_ContaBancaria.Exceptions;

namespace Atividade1_ContaBancaria.Entities;

public class ContaBancaria
{
    private double saldo;
    private string titular ;

    public ContaBancaria(double saldo, string titular)
    {
        this.saldo = saldo;
        this.titular = titular;
    }

    public void Sacar(double valor)
    {
        if(valor <= 0)
        {
            throw new ValorInvalidoException("Valor inválido", valor);
        }
        if (valor > saldo)
        {
            throw new SaldoInsuficienteException("Saldo insuficiente",saldo);
        }
        saldo -= valor;
    }

    public void Depositar(double valor)
    {
        if(valor <= 0)
        {
            throw new ValorInvalidoException("Valor inválido", valor);
        }
        saldo += valor;
    }

    public void Transferir(double valor, ContaBancaria contaDestino)
    {
        /*As validações de valor valido e saldo insuficiente serão feitos no metodo sacar*/
        Sacar(valor);
        contaDestino.Depositar(valor);
    }

    public double GetSaldo()
    {
        return saldo;
    }

    public string GetTitular()
    {
        return titular;
    }


}
