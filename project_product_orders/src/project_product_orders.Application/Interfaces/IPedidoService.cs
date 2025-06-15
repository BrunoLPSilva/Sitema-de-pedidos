
using Application.DTOs;
using project_product_orders.application.DTOs;

namespace API_Clean_Solution.Application.Interfaces;

public interface IPedidoService
{
    Task<int> CriarPedidoAsync(CriarPedidoDTO pedido);
    Task<IEnumerable<PedidoDTO>> ListarPedidosAsync(string? status = null);
    Task AtualizarStatusAsync(int id, string novoStatus);
    
}
