using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComentariosApi.Models.Entidades
{
    public class ComentarioEntidade
    {
        public ObjectId Id { get; set; }

        [BsonElement("usuarioId")]
        public int UsuarioId { get; set; }

        [BsonElement("livroId")]
        public int LivroIsbn { get; set; }

        [BsonElement("avaliacao")]
        public int Avaliacao { get; set; }

        [BsonElement("mensagem")]
        public string Mensagem { get; set; }
    }
}
