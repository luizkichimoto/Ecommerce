namespace Ecommerce.entities;

public class Pedido
{
    public Guid Id { get; private set; }
    public Guid ClienteId { get; private set; }
    public DateTime DataPedido { get; private set; }
    public decimal ValorTotal { get; private set; }
    
    public Cliente Cliente { get; private set; }
    
    public ICollection<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();

    protected Pedido() { }

    public Pedido(Guid clienteId, Cliente cliente)
    {
        Id = Guid.NewGuid();
        ClienteId = clienteId;
        Cliente = cliente;
        DataPedido = DateTime.UtcNow;
        ValorTotal = 0;
    }
}
