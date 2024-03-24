// See https://aka.ms/new-console-template for more information
using questao2.entities;

ICollection<ItemMercado> compras = ItemMercado.ListaFake();

//Retorne uma lista de itens do tipo Higiene ordenados por ordem decrescente de preço.
var filtro = compras.Where(item => item.Tipo == Tipo.Higiene).OrderByDescending(item => item.Preco).ToList();
Console.WriteLine("Produtos de higiene do mais caro ao mais barato");
filtro.ForEach(x => Console.WriteLine($"Nome: {x.Nome}, Preço: R$ {x.Preco.ToString("0.00")}"));


// Retorne uma lista de itens cujo preço seja maior ou igual a R$ 5,00. 
//A ordenação deve ser
// feita por ordem crescente de preço.
filtro = compras.Where(item => item.Preco >= 5).OrderBy(item => item.Preco).ToList();
Console.WriteLine("\nProdutos com preço a partir de R$5,00");
filtro.ForEach(x => Console.WriteLine($"Nome: {x.Nome}, Preço: R$ {x.Preco.ToString("0.00")}"));


// 3) Retorne uma lista de itens cujo tipo seja Comida ou Bebida. 
//A ordenação deve ser feita por
// nome em ordem alfabética.
filtro = compras.Where(item => item.Tipo == Tipo.Comida || item.Tipo == Tipo.Bebida).OrderBy(item => item.Nome).ToList();
Console.WriteLine("\nProdutos de Comida ou Bebida");
filtro.ForEach(x => Console.WriteLine($"Nome: {x.Nome}, Preço: R$ {x.Preco.ToString("0.00")}"));


// 4) Retorne cada um dos tipos associado com a quantidade de itens de cada tipo.
var quantidadeDeItensPorTipo = compras.GroupBy(item => item.Tipo)
                .Select(group => new { Tipo = group.Key, Quantidade = group.Count() })
                .ToList();
Console.WriteLine("\nQuantidade de itens por tipo:");
quantidadeDeItensPorTipo.ForEach(x => Console.WriteLine($"{x.Tipo}\t{x.Quantidade}"));

// 5) Retorne cada um dos tipos associado com o preço máximo, 
//preço mínimo e média de preço
// de cada tipo
var tiposAssociadosPrecoMaxPrecoMinMedia = compras.GroupBy(item => item.Tipo)
    .Select(group => new
    {
        Tipo = group.Key,
        PrecoMaximo = group.Max(item => item.Preco),
        PrecoMinimo = group.Min(item => item.Preco),
        PrecoMedio = group.Average(item => item.Preco)
    })
    .ToList();

Console.WriteLine("\nResumo das categorias");
Console.WriteLine("Nome\tMax\tMin\tMedia");
tiposAssociadosPrecoMaxPrecoMinMedia.ForEach(item => Console.WriteLine($"{item.Tipo}\t{item.PrecoMaximo.ToString("0.00")}\t{item.PrecoMinimo.ToString("0.00")}\t{item.PrecoMedio.ToString("0.00")}"));

