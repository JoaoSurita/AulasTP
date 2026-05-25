using MongoDB.Driver;
using TodoAqui.Models;

namespace TodoAqui.Repositories
{
    public class TarefaRepository
    {
        private readonly IMongoCollection<Tarefa> _tarefasCollection;

        public TarefaRepository(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MongoConnection");
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("TodoDatabase");
            _tarefasCollection = database.GetCollection<Tarefa>("Tarefas");
        }
        public async Task<List<Tarefa>> ObterTodasTarefasAsync()=> 
            await _tarefasCollection.Find(_=> true).ToListAsync();

        public async Task CriarTarefaAsync(Tarefa novaTarefa) =>
            await _tarefasCollection.InsertOneAsync(novaTarefa); 
    }
}
