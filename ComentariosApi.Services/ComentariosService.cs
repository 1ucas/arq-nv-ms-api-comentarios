using ComentariosApi.Models.DTOs;
using ComentariosApi.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComentariosApi.Services
{
    public class ComentariosService
    {
        public List<ComentarioDTO> ListarPorUsuario(int idUsuario)
        {
            var listaComentarios = new ComentariosRepo().ListarPorUsuario(idUsuario);
            var listaComentariosDTO = ComentarioDTO.From(listaComentarios);
            return listaComentariosDTO;
        }

        public List<ComentarioDTO> ListarPorLivro(int idLivro)
        {
            var listaComentarios = new ComentariosRepo().ListarPorLivro(idLivro);
            var listaComentariosDTO = ComentarioDTO.From(listaComentarios);
            return listaComentariosDTO;
        }

        public void Inserir(ComentarioDTO comentario)
        {
            new ComentariosRepo().Inserir(comentario.UsuarioId, comentario.LivroIsbn, comentario.Avaliacao, comentario.Mensagem);
        }

        public void Remover(ComentarioDTO comentario)
        {
            new ComentariosRepo().Remover(comentario.ComentarioId);
        }
    }
}
