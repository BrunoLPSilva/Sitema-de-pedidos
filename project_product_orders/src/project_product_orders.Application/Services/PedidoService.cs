

using API_Clean_Solution.Application.Interfaces;
using Application.DTOs;
using project_product_orders.application.DTOs;
using project_product_orders.domain.Entities;
using project_product_orders.domain.Interfaces;

namespace API_Clean_Solution.Application.Services;

public class PedidoService : IPedidoService
{
    private readonly IPedidoRepository _pedidoRepo;

    public PedidoService(IPedidoRepository pedidoRepo)
    {
        _pedidoRepo = pedidoRepo;
    }

    public async Task<int> CriarPedidoAsync(CriarPedidoDTO dto)
    {
        var pedido = new Pedido
        {
            Cliente = dto.Cliente,
            DataCriacao = DateTime.UtcNow,
            Status = dto.Status,
            Itens = dto.Itens.Select(i => new ItemPedido
            {
                NomeProduto = i.NomeProduto,
                Quantidade = i.Quantidade,
                PrecoUnitario = i.PrecoUnitario
            }).ToList()
        };

        return await _pedidoRepo.AdicionarAsync(pedido);
    }

    public async Task<IEnumerable<PedidoDTO>> ListarPedidosAsync(string? status = null)
    {
        var pedidos = await _pedidoRepo.ObterTodosAsync(status);
        return pedidos.Select(p => new PedidoDTO
        {
            Id = p.Id,
            Cliente = p.Cliente,
            DataCriacao = p.DataCriacao,
            Status = p.Status,
            Itens = p.Itens.Select(i => new ItemPedidoDTO
            {
                NomeProduto = i.NomeProduto,
                Quantidade = i.Quantidade,
                PrecoUnitario = i.PrecoUnitario
            }).ToList()
        });
    }

    public async Task AtualizarStatusAsync(int id, string novoStatus)
    {
        await _pedidoRepo.AtualizarStatusAsync(id, novoStatus);
    }


}
