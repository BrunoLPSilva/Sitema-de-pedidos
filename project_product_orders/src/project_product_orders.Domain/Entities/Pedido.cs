namespace project_product_orders.domain.Entities;

public class Pedido
{
    public int Id { get; set; }
    public string Cliente { get; set; } = string.Empty;
    public List<ItemPedido> Itens { get; set; } = new();
    public string Status { get; set; } = "Pendente";
    public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
}

public class ItemPedido
{
    public int Id { get; set; }
    public string NomeProduto { get; set; } = string.Empty;
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
    public int PedidoId { get; set; }
}
