using Microsoft.AspNetCore.Mvc;
using project_product_orders.application.DTOs;
using project_product_orders.application.Interfaces;
using project_product_orders.Application.DTOs;

namespace project_product_orders.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly IProdutoService _service;

    public ProdutosController(IProdutoService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _service.ListarProdutosAsync());
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ProdutoDTO dto)
    {
        var id = await _service.CriarProdutoAsync(dto);
        return CreatedAtAction(nameof(Get), new { id }, null);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Atualizar(int id, [FromBody] ProdutoUpdateDTO dto)
    {
        if (id != dto.Id)
            return BadRequest();

        await _service.AtualizarProdutoAsync(dto);
        return NoContent();
    }

}
