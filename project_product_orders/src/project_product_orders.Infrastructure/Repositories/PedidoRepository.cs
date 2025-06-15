
using Microsoft.EntityFrameworkCore;
using project_product_orders.domain.Entities;
using project_product_orders.domain.Interfaces;
using project_product_orders.Infrastructure.Context;

namespace Project_Product_Orders.infrastructure.Repositories;

public class PedidoRepository : IPedidoRepository
{
    private readonly AppDbContext _context;

    public PedidoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<int> AdicionarAsync(Pedido pedido)
    {
        _context.Pedidos.Add(pedido);
        await _context.SaveChangesAsync();
        return pedido.Id;
    }

    public async Task<IEnumerable<Pedido>> ObterTodosAsync(string? status = null)
    {
        var query = _context.Pedidos.Include(p => p.Itens).AsQueryable();
        if (!string.IsNullOrWhiteSpace(status))
        {
            query = query.Where(p => p.Status == status);
        }
        return await query.ToListAsync();
    }

    public async Task AtualizarStatusAsync(int id, string novoStatus)
    {
        var pedido = await _context.Pedidos.FindAsync(id);
        if (pedido != null)
        {
            pedido.Status = novoStatus;
            await _context.SaveChangesAsync();
        }
    }
}
