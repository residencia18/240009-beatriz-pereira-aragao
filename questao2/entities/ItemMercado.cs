namespace questao2.entities;

public class ItemMercado
{
    public string Nome { get; set; }
    public Tipo Tipo { get; set; }
    public double Preco { get; set; }

    public ItemMercado(string nome, Tipo tipo, double preco)
    {
        Nome = nome;
        Tipo = tipo;
        Preco = preco;
    }

    public static ICollection<ItemMercado> ListaFake()
    {
        List<ItemMercado> itens = new List<ItemMercado>();
        itens.Add(new ItemMercado("Arroz", Tipo.Comida, 3.90));
        itens.Add(new ItemMercado("Azeite", Tipo.Comida, 2.50));
        itens.Add(new ItemMercado("Macarrão", Tipo.Comida, 3.90));
        itens.Add(new ItemMercado("Cerveja", Tipo.Bebida, 22.90));
        itens.Add(new ItemMercado("Refrigerante", Tipo.Bebida, 5.50));
        itens.Add(new ItemMercado("Shampoo", Tipo.Higiene, 7.00));
        itens.Add(new ItemMercado("Sabonete", Tipo.Higiene, 2.40));
        itens.Add(new ItemMercado("Cotonete", Tipo.Higiene, 5.70));
        itens.Add(new ItemMercado("Sabão em pó", Tipo.Limpeza, 8.20));
        itens.Add(new ItemMercado("Detergente", Tipo.Limpeza, 2.60));
        itens.Add(new ItemMercado("Amaciante", Tipo.Limpeza, 6.40));
        return itens;
    }

}
