namespace Ecommerce.entities;

public class ItemPedido
{
    public Guid Id { get; private set; }
    public Guid PedidoId { get; private set; }
    public Guid ProdutoId { get; private set; }
    public int Quantidade { get; private set; }
    public decimal PrecoUnitario { get; private set; }


    public Pedido Pedido { get; private set; }
    public Produto Produto { get; private set; }

    protected ItemPedido() { }

    public ItemPedido(Guid pedidoId, Pedido pedido, Guid produtoId, Produto produto, int quantidade, decimal precoUnitario)
    {
        Id = Guid.NewGuid();
        PedidoId = pedidoId;
        Pedido = pedido;
        ProdutoId = produtoId;
        Produto = produto;
        Quantidade = quantidade;
        PrecoUnitario = precoUnitario;
    }
}
