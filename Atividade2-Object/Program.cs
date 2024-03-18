object o = null;
try
{
    Console.WriteLine(o.ToString());
}
catch (NullReferenceException)
{
    Console.WriteLine("O objeto é nulo, não é possivel chamar o metodo ToString()");
    // Console.WriteLine("Tipo: " + e.GetType()); // System.NullReferenceException
}

