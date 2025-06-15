namespace Application.DTOs;

public class ItemPedidoDTO
{
    public string NomeProduto { get; set; } = string.Empty;
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
}