# Exercícios de Programação em C#

Este é um projeto contendo soluções para uma série de exercícios de programação em C#.

## Exercício 1: Conta Bancária

- `ContaBancaria`: Classe que representa uma conta bancária com métodos para sacar, depositar e transferir dinheiro, incluindo tratamento de exceções para valores inválidos e saldo insuficiente.
- `ValorInvalidoException`: Exceção lançada quando um valor inválido é utilizado em uma operação de depósito, saque ou transferência.
- `SaldoInsuficienteException`: Exceção lançada quando o valor de saque ou transferência é superior ao saldo disponível.

## Exercício 2: Manipulação de Exceções

- O código `object o = null; o.toString();` lança uma exceção `NullReferenceException`.
- Uma mensagem amigável pode ser exibida ao usuário informando que ocorreu um erro de referência nula.

## Exercício 3: Enum de Exercícios

- `Exercicio`: Enum que define opções de exercícios, incluindo Academia, Luta e Corrida.
- O programa solicita ao usuário a entrada de um número (1, 2 ou 3) representando uma opção de exercício e exibe o nome do exercício associado a essa opção.

## Exercício 4: Serviço de Fábrica Genérico

- `ServicoFabrica<T>`: Classe genérica que cria instâncias de objetos do tipo `T`, desde que `T` implemente a interface `IServico`.
- `IServico`: Interface que define um método `Executar()` a ser implementado pelas classes que a implementam.

## Exercício 5: Triângulo e Ponto Genéricos

- `Ponto<T>`: Estrutura que representa um ponto com coordenadas X, Y e Z de tipo genérico `T`.
- `Triangulo<T>`: Estrutura que representa um triângulo com três pontos genéricos.
- O método `Main()` do programa cria diferentes triângulos e pontos com tipos de dados diferentes para validar a implementação.
