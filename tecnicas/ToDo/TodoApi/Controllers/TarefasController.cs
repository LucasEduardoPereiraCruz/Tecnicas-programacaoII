using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using TodoApi.Models;
using TodoApi.Repositories;

namespace TodoApi.Controllers 
{
    [ApiController] // Ativa recursos automáticos: validação automática do modelo, respostas HTTP mais inteligentes, binding automático (JSON → objeto C#)
    [Route("api/[controller]")] // Define a rota API 
    public class TarefasController : Controller // Herença 
    {
        private readonly TarefaRepository _repository;  

        // Injeção de dependencia  
        public TarefasController(TarefaRepository repository)
        {
            _repository = repository;
        }
        [HttpGet] // Buscar tarefas - Busca todas as tarefas 
        public async Task<ActionResult<List<Tarefa>>> Get()
        {
            var tarefas = await _repository.ObterTodasTarefasAsync(); // chama o banco via repository 
            return Ok(tarefas); // retorna HTTP - Lista de tarefas em JSON 
        }
        [HttpPost]
        public async Task<IActionResult> Post(Tarefa novaTarefa) // Criar tarefa 
        {
            await _repository.CriarTarefaAsync(novaTarefa); // Manda salvar no banco 
            return CreatedAtAction(nameof(Get), new { id = novaTarefa.Id }, novaTarefa); // objeto criado 
        }
        [HttpDelete("{id}")] // Delete 
        public async Task<IActionResult> Delete(string id)
        {
            
            await _repository.DeletarAsync(id); // manda deletar do banco 

            return NoContent(); // Deu certo - sem retorno 
        }
        [HttpPatch("{id}")] // Patch (Alterar status) - ele pega o id da tarefa
        public async Task<IActionResult> PatchStatus(string id, [FromBody] bool cancelado) // é bool pq pode ser ou true ou false
        {
            
            await _repository.AlterarStatusAsync(id, cancelado); // atualiza só um campo (status)

            //Retorna 204 NoContent (Sucesso, sem conteúdo para devolver)
            return NoContent();
        }
        [HttpPut("{id}")] // Atualiza uma tarefa inteira 
        public async Task<IActionResult> Put(string id, [FromBody] Tarefa tarefaAtualizada) // [FromBody] é uma instrução que diz para o ASP.NET:
                                                                                            // “pega os dados que vêm no corpo (body) da requisição HTTP e coloca aqui nesse parâmetro”
        {
            
            await _repository.AtualizarTotalAsync(id, tarefaAtualizada); // manda substituir uma tarefa inteira do banco

            //Retorna 204 NoContent (Sucesso, sem conteúdo para devolver)
            return NoContent();
        }
    }
}

