namespace Ecommerce.entities;

public class Produto
{
    public Guid Id { get; private set; }
    public Guid CategoriaId { get; private set; }
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    public int Estoque { get; private set; }
    
    public Categoria Categoria { get; private set; }
    
    public ICollection<ItemPedido> ItensPedido { get; private set; } = new List<ItemPedido>();

    protected Produto() { }

    public Produto(Guid categoriaId, Categoria categoria, string nome, decimal preco, int estoque)
    {
        Id = Guid.NewGuid();
        CategoriaId = categoriaId;
        Categoria = categoria;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }
}
