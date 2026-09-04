namespace Ecommerce.entities;

public class Carrinho
{
    public Guid Id { get; private set; }
    public Guid ClienteId { get; private set; }
    public DateTime DataCriacao { get; private set; }
    public bool Ativo { get; private set; }

    public Cliente Cliente { get; private set; }

    protected Carrinho() { }

    public Carrinho(Guid clienteId, Cliente cliente)
    {
        Id = Guid.NewGuid();
        ClienteId = clienteId;
        Cliente = cliente;
        DataCriacao = DateTime.UtcNow;
        Ativo = true;
    }
}
