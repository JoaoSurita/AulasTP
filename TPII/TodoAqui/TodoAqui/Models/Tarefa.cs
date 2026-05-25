using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TodoAqui.Models
{
    public class Tarefa
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string? Id { get; set; }
        [BsonElement("titulo")]
        public string? Titulo { get; set; }

        [BsonElement("descricao")]
        public string? Descricao { get; set; }

        [BsonElement("cancelado")]
        public string? Cancelado { get; set; }
    }
}
