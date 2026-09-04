namespace Ecommerce.entities;

public class Categoria
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string? Descricao { get; private set; } 
    
    public ICollection<Produto> Produtos { get; private set; } = new List<Produto>();

    protected Categoria() { }

    public Categoria(string nome, string? descricao = null)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Descricao = descricao;
    }
}
