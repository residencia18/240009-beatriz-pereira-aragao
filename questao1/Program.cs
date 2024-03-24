// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

List<Double> lista = new List<double>{3, 7, 2, 4, 6};

List<Double> novaLista = lista.ConvertAll( x => x/2);

novaLista.ForEach(x => Console.WriteLine(x));

