// See https://aka.ms/new-console-template for more information
using questao3.entities;

Worker worker = new Worker();

// Criando duas threads para executar o método DoWork
Thread thread1 = new Thread(worker.DoWork);
Thread thread2 = new Thread(worker.DoWork);

// Iniciando as threads
thread1.Start();
thread2.Start();

// Aguardando até que ambas as threads tenham terminado de executar
thread1.Join();
thread2.Join();

Console.WriteLine("Ambas as threads terminaram. Programa encerrado.");
