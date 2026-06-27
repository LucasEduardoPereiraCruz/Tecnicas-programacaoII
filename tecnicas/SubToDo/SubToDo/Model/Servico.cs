using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SubToDo.Model
{
    public class Servico
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string? Id { get; set; }

        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public decimal Valor { get; set; }
    }
}
