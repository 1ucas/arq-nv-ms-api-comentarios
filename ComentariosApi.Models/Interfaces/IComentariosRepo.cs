using System.Collections.Generic;
using ComentariosApi.Models.Entidades;

namespace ComentariosApi.Models.Interfaces
{
    public interface IComentariosRepo
    {
        List<ComentarioEntidade> ListarPorUsuario(int idUsuario);

        List<ComentarioEntidade> ListarPorLivro(int idLivro);

        void Remover(string comentarioId);

        void Inserir(int idUsuario, int idLivro, int avaliacao, string mensagem);
    }
}
