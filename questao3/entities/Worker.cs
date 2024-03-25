namespace questao3.entities;

class Worker
{
    public void DoWork()
    {
        for (int i = 1; i <= 2; i++)
        {
            Console.WriteLine($"Thread({Thread.CurrentThread.ManagedThreadId}): Tarefa {i} iniciada...");
            Thread.Sleep(1000); // Simula algum processamento demorado
            Console.WriteLine($"Thread({Thread.CurrentThread.ManagedThreadId}): Tarefa {i} concluída!");
        }
    }
}
