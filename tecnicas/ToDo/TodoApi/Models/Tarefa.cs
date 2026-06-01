using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TodoApi.Models
{
    public class Tarefa // Ele define como uma tarefa existe dentro da aplicação e do banco de dados Essa classe vira:  ✔️ objeto no C#, ✔️ documento no MongoDB(JSON)

    {
        [BsonId] // diz que isso é o ID principal no MongoDB
        [BsonRepresentation(BsonType.ObjectId)] // Mongo usa ObjectId (tipo "65f1a9...")
        public string? Id { get; set; } // pode ser nulo quando ainda não foi criado
        [BsonElement("titulo")] // esse campo será salvo no MongoDB como "titulo"
        public string Titulo { get; set; }

        [BsonElement("descricao")]
        public string Descricao { get; set; }

        [BsonElement("cancelado")]
        public bool Cancelado { get; set; }

    }
}
