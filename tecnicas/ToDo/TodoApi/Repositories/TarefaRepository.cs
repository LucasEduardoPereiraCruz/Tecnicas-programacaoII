// Esse arquivo é o CRUD do mongoDB

using MongoDB.Driver;
using TodoApi.Models;

namespace TodoApi.Repositories
{
    public class TarefaRepository
    {
        private readonly IMongoCollection<Tarefa> _tarefasCollection; // Coleção tarefas 
        public TarefaRepository(IConfiguration configuration) // recebe configurações do sistema (appsettings.json) 
        {
            var connectionString = configuration.GetConnectionString("MongoConnection"); // pega a string de conexão do MongoDB
            var client = new MongoClient(connectionString); // cria a conexão 
            var database = client.GetDatabase("TodoDatabase"); // Escolhe o banco 
            _tarefasCollection = database.GetCollection<Tarefa>("Tarefas"); // pega a coleção (tipo tabela)
        }

        public async Task<List<Tarefa>> ObterTodasTarefasAsync() =>    // pegar todas as tarefas - Busca todas as tarefas do banco 
            await _tarefasCollection.Find(_ => true).ToListAsync();

        public async Task CriarTarefaAsync(Tarefa novaTarefa) =>       // nsere uma nova tarefa no MongoDB
            await _tarefasCollection.InsertOneAsync(novaTarefa);

        public async Task DeletarAsync(string id) // recebe o id da tarefa   // DELETAR  
        {
            var filtro = Builders<Tarefa>.Filter.Eq(tarefa => tarefa.Id, id); // cria um filtro:
            await _tarefasCollection.DeleteOneAsync(filtro); // apaga essa tarefa
        }
        public async Task AlterarStatusAsync(string id, bool cancelado) // Alterar Status 
        {
            var filtro = Builders<Tarefa>.Filter.Eq(tarefa => tarefa.Id, id); // encontra a tarefa pelo id

            var atualizacao = Builders<Tarefa>.Update.Set(tarefa => tarefa.Cancelado, cancelado); // cria atualização: mudar campo Cancelado

            await _tarefasCollection.UpdateOneAsync(filtro, atualizacao); // aplica a mudança
        }
        public async Task AtualizarTotalAsync(string id, Tarefa tarefaAtualizada) // PUT 
        {
          
            var filtro = Builders<Tarefa>.Filter.Eq(tarefa => tarefa.Id, id); // encontra a tarefa


            tarefaAtualizada.Id = id; // garante que o id não muda


            await _tarefasCollection.ReplaceOneAsync(filtro, tarefaAtualizada); // substitui a tarefa inteira no banco
        }
    }
}
