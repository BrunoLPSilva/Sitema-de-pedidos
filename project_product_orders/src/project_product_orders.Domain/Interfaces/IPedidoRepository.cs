using project_product_orders.domain.Entities;

namespace project_product_orders.domain.Interfaces;

public interface IPedidoRepository
{
    Task<int> AdicionarAsync(Pedido pedido);
    Task<IEnumerable<Pedido>> ObterTodosAsync(string? status = null);
    Task AtualizarStatusAsync(int id, string novoStatus);
}
