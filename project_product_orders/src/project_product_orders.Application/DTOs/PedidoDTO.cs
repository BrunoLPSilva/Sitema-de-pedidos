namespace Application.DTOs;

public class PedidoDTO 
{
    public int Id { get; set; }                     
    public string Cliente { get; set; } = string.Empty;
    public DateTime DataCriacao { get; set; }      
    public List<ItemPedidoDTO> Itens { get; set; } = new();
    public string Status { get; set; }
}