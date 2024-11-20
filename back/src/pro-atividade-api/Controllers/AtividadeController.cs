using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pro_atividade_domain.Entities;
using pro_atividade_domain.Interfaces.Services;

namespace pro_atividade_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtividadeController : ControllerBase
    {
        public readonly IAtividadeService _atividadeService;
        public AtividadeController(IAtividadeService atividadeService)
        {
            _atividadeService = atividadeService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var atividades = await _atividadeService.GetAllAtividadesAsync();
                if (atividades == null)
                {
                    return NoContent();
                }

                return Ok(atividades);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar buscar as atividades. Erro: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var atv = await _atividadeService.GetByIdAtividadeAsync(id);
                if (atv == null)
                {
                    return NoContent();
                }

                return Ok(atv);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar buscar a atividade com id: {id}. Erro: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Atividade atv)
        {
            try
            {
                var ativ = await _atividadeService.AddAtividade(atv);
                if (ativ == null)
                {
                    return NoContent();
                }

                return Ok(ativ);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar adicionar a atividade id: {atv.Id}. Erro: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Atividade atv)
        {
            try
            {
                if (atv.Id != id)
                {
                    return StatusCode(StatusCodes.Status409Conflict, "Você está tentando atualizar a atividade errada.");
                }

                var atvUpdate = await _atividadeService.UpdateAtividade(atv);
                if (atvUpdate == null)
                {
                    return NoContent();
                }

                return Ok(atvUpdate);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar atualizar a atividade id: {atv.Id}. Erro: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var atv = await _atividadeService.GetByIdAtividadeAsync(id);
                if (atv == null)
                {
                    return StatusCode(StatusCodes.Status409Conflict, "Você está tentando deletar atividade que não existe.");
                }

                if (await _atividadeService.DeleteAtividade(id))
                {
                    return Ok(new { message = "Deletado" });
                }
                else
                {
                    return BadRequest("Ocorreu um erro ao tentar deletar");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar deletar a atividade id: {id}. Erro: {ex.Message}");
            }
        }
    }
}