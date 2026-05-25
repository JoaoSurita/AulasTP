using Microsoft.AspNetCore.Mvc;
using TodoAqui.Models;
using TodoAqui.Repositories;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefasController : Controller
    {
        private readonly TarefaRepository _repository;

        public TarefasController(TarefaRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Tarefa>>> Get()
        {
            var tarefas = await _repository.ObterTodasTarefasAsync();
            return Ok(tarefas);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Tarefa novaTarefa)
        {
            await _repository.CriarTarefaAsync(novaTarefa);
            return CreatedAtAction(nameof(Get), new {id = novaTarefa.Id}, novaTarefa);
        }
    }
}
