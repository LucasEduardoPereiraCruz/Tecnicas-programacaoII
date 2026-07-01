using Microsoft.AspNetCore.Mvc;
using SubToDo.Model;
using SubToDo.Repositories;

namespace SubToDo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicosController : Controller
    {
        private readonly ServicoRepository _repository;

        // Injeção de dependencia  
        public ServicosController(ServicoRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("{valor}")] // Buscar tarefas - Busca todas as tarefas 
        public async Task<ActionResult<List<Servico>>> Get(decimal valor)
        {
            var servicos = await _repository.BuscarPorValorAsync(valor); // chama o banco via repository 
            return Ok(servicos); // retorna HTTP - Lista de tarefas em JSON 
        }

        [HttpGet] // GET PARA LISTAR TODOS OS SERVIÇOS 
        public async Task<ActionResult<List<Servico>>> Get()
        {
            var servicos = await _repository.ObterServicosAsync();

            return Ok(servicos);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Servico novoServico) // Criar tarefa 
        {
            await _repository.CriarServicosAsync(novoServico); // Manda salvar no banco 
            return CreatedAtAction(nameof(Get), new { id = novoServico.Id }, novoServico); // objeto criado 
        }
        
    }
}
