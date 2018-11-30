using ComentariosApi.Models.Entidades;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComentariosApi.Models.Interfaces;

namespace ComentariosApi.Repos
{
    public class ComentariosRepo : IComentariosRepo
    {
        private IMongoDatabase DbComentarios { get; }
        private IMongoCollection<ComentarioEntidade> Comentarios { get; }

        public ComentariosRepo()
        {
            string connectionString = "mongodb://ms-comentarios:lucas-1234@ds115664.mlab.com:15664/comentarios-db";
            MongoClient client = new MongoClient(connectionString);
            DbComentarios = client.GetDatabase("comentarios-db");
            Comentarios = DbComentarios.GetCollection<ComentarioEntidade>("comentarios");
        }

        public List<ComentarioEntidade> ListarPorUsuario(int idUsuario)
        {
            return Comentarios.FindSync(f => f.UsuarioId == idUsuario).ToList();
        }

        public List<ComentarioEntidade> ListarPorLivro(int idLivro)
        {
            return Comentarios.FindSync(f => f.LivroIsbn == idLivro).ToList();
        }

        public void Remover(string comentarioId)
        {
            Comentarios.DeleteOne(f => f.Id == ObjectId.Parse(comentarioId));
        }

        public void Inserir(int idUsuario, int idLivro, int avaliacao, string mensagem)
        {
            var novoComentario = new ComentarioEntidade
            {
                LivroIsbn = idLivro,
                UsuarioId = idUsuario,
                Avaliacao = avaliacao,
                Mensagem = mensagem
            };

            Comentarios.InsertOne(novoComentario);
        }
    }
}
