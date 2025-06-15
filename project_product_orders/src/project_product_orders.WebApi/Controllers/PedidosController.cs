using API_Clean_Solution.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using project_product_orders.application.DTOs;


namespace project_product_orders.WebApi_rest.Controllers;

[ApiController]
[Route("Dados/[controller]")]
public class PedidosController : ControllerBase
{
    private readonly IPedidoService _service;

    public PedidosController(IPedidoService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] string? status) =>
        Ok(await _service.ListarPedidosAsync(status));

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CriarPedidoDTO dto)
    {
        var id = await _service.CriarPedidoAsync(dto);
        return CreatedAtAction(nameof(Get), new { id }, null);
    }

    [HttpPatch("{id}/status")]
    public async Task<IActionResult> PatchStatus(int id, [FromBody] string novoStatus)
    {
        await _service.AtualizarStatusAsync(id, novoStatus);
        return NoContent();
    }
}