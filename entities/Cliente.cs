namespace Ecommerce.entities;
public class Cliente
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string Cpf { get; private set; }
    public DateTime DataCadastro { get; private set; }
    
    public Carrinho? Carrinho { get; private set; }

    public ICollection<Pedido> Pedidos { get; private set; } = new List<Pedido>();

    protected Cliente() { }

    public Cliente(string nome, string email, string cpf)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Email = email;
        Cpf = cpf;
        DataCadastro = DateTime.UtcNow;
    }
}
