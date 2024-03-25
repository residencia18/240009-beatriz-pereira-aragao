// See https://aka.ms/new-console-template for more information
static async Task DoWorkAsync(string taskName)
{
    Console.WriteLine($"{taskName} iniciada.");

    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine($"{taskName} progresso: {i}/5");
        await Task.Delay(1000);
    }

    Console.WriteLine($"{taskName} concluída.");
}

Task task1 = DoWorkAsync("Tarefa 1");
Task task2 = DoWorkAsync("Tarefa 2");

await Task.WhenAll(task1, task2);

Console.WriteLine("Ambas as tarefas foram concluídas. Programa encerrado.");

