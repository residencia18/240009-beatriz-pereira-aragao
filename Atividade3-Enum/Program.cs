using Atividade3_Enum;
Tipo tipo;
Console.WriteLine("Digite o tipo de atividade que deseja fazer: ");
foreach (var item in Enum.GetValues(typeof(Tipo)))
{
    Console.WriteLine((int)item + "-"+ item);
}
try
{
    tipo = (Tipo)int.Parse(Console.ReadLine());
    if (!Enum.IsDefined(typeof(Tipo), tipo))
    {
        throw new Exception();
    }
}
catch (Exception)
{
    Console.WriteLine("Opção inválida");
    return;
}
Console.WriteLine("Você escolheu a atividade: " + tipo);


