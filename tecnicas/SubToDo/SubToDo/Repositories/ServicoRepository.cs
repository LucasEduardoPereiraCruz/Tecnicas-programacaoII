using MongoDB.Driver;
using SubToDo.Model;

namespace SubToDo.Repositories
{
    public class ServicoRepository
    {
        private readonly IMongoCollection<Servico> _servicosCollection; // Coleção Serviços 
        public ServicoRepository(IConfiguration configuration) // recebe configurações do sistema (appsettings.json) 
        {
            var connectionString = configuration.GetConnectionString("MongoConnection"); // pega a string de conexão do MongoDB
            var client = new MongoClient(connectionString); // cria a conexão 
            var database = client.GetDatabase("TodoDatabase"); // Escolhe o banco 
            _servicosCollection = database.GetCollection<Servico>("Serviços"); // pega a coleção (tipo tabela)
        }

        public async Task<List<Servico>> ObterServicosAsync() =>    // pegar todos os Serviços - Busca todos os serviços do banco 
            await _servicosCollection.Find(_ => true).ToListAsync();

        public async Task CriarServicosAsync(Servico novoServico) =>       // insere um novo serviço no MongoDB
            await _servicosCollection.InsertOneAsync(novoServico);


        public async Task<List<Servico>> BuscarPorValorAsync(decimal valor) => 
            await _servicosCollection.Find(servico => servico.Valor > valor).ToListAsync();     // Busca pelo valor informado do parametro do controller 
    }
}
