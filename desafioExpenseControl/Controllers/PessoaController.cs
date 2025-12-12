using desafioExpenseControl.Application.Dtos;
using ExpenseControl.Application.DTOs;
using ExpenseControl.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseControl.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] CreatePessoaDto dto)
        {
            try
            {
                var result = await _pessoaService.CriarAsync(dto);
                return StatusCode(201, result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }           

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(PessoaDto), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ObterPorId(int id)
        {
            try
            {
                var pessoa = await _pessoaService.ObterPorIdAsync(id);
                return Ok(pessoa);
            }
            catch (Exception ex)
            {                
                if (ex.Message == "Pessoa não encontrada.")
                    return NotFound(new { message = ex.Message });

                return StatusCode(500, new { error = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var result = await _pessoaService.ListarTodasAsync();
            return Ok(result);
        }

        [HttpGet("totais")]
        public async Task<IActionResult> ListarTotais()
        {
            // Endpoint para o relatório do teste
            var result = await _pessoaService.ListarTotaisAsync();
            return Ok(result);
        }
    
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]  
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Deletar(int id)
        {
            try
            {
                await _pessoaService.DeletarAsync(id);
                return Ok(new { message = "Pessoa deletada com sucesso!" });
            }
            catch (Exception ex)
            {                
                if (ex.Message == "Pessoa não encontrada.")
                    return NotFound(new { message = ex.Message });

                return StatusCode(500, new { error = ex.Message });
            }
        }
    }

}