using Atividade1_ContaBancaria.Entities;
using Atividade1_ContaBancaria.Exceptions;

ContaBancaria c1 = new ContaBancaria(1000, "Lucas");
ContaBancaria c2 = new ContaBancaria(10, "João");

void ImprimirSaldo(ContaBancaria conta)
{
    Console.WriteLine("Saldo atual de " + conta.GetTitular() + " : " + conta.GetSaldo());
}
void ImprimirOperacao(ContaBancaria conta, string operacao, double valor)
{
    Console.WriteLine("\nOperação: " + operacao + " Valor: " + valor + " Titular: " + conta.GetTitular());
}
//transações corretas
ImprimirOperacao(c1, "Saque", 100);
c1.Sacar(100);
ImprimirSaldo(c1);

ImprimirOperacao(c1, "Transferencia", 100);
c1.Transferir(100, c2);
ImprimirSaldo(c1);
ImprimirSaldo(c2);

ImprimirOperacao(c2, "Deposito", 100);
c2.Depositar(100);
ImprimirSaldo(c2);

//transações incorretas
ImprimirOperacao(c1, "Saque", 10000);
try
{
    c1.Sacar(10000);
}
catch (SaldoInsuficienteException e)
{
    Console.WriteLine("Erro: " + e.Message + " Saldo atual: " + e.Valor);
}

ImprimirOperacao(c1, "Deposito", -100);
try
{
    c1.Depositar(-100);
}
catch (ValorInvalidoException e)
{
    Console.WriteLine("Erro: " + e.Message + " Valor: " + e.Valor);
}

ImprimirOperacao(c1, "Transferencia", 10000);
try
{
    c1.Transferir(10000, c2);
}
catch (SaldoInsuficienteException e)
{
    Console.WriteLine("Erro: " + e.Message + " Saldo atual: " + e.Valor);
}
catch (ValorInvalidoException e)
{
    Console.WriteLine("Erro: " + e.Message + " Valor: " + e.Valor);
}


