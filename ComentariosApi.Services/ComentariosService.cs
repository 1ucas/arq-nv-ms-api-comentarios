using System.Collections.Generic;
using ComentariosApi.Models.DTOs;
using ComentariosApi.Models.Interfaces;

namespace ComentariosApi.Services
{
    public class ComentariosService : IComentariosService
    {
        private readonly IComentariosRepo _comentariosRepo;
        public ComentariosService(IComentariosRepo comentariosRepo)
        {
            _comentariosRepo = comentariosRepo;
        }
        public List<ComentarioDTO> ListarPorUsuario(int idUsuario)
        {
            var listaComentarios = _comentariosRepo.ListarPorUsuario(idUsuario);
            var listaComentariosDTO = ComentarioDTO.From(listaComentarios);
            return listaComentariosDTO;
        }

        public List<ComentarioDTO> ListarPorLivro(int idLivro)
        {
            var listaComentarios = _comentariosRepo.ListarPorLivro(idLivro);
            var listaComentariosDTO = ComentarioDTO.From(listaComentarios);
            return listaComentariosDTO;
        }

        public void Inserir(ComentarioDTO comentario)
        {
            _comentariosRepo.Inserir(comentario.UsuarioId, comentario.LivroIsbn, comentario.Avaliacao, comentario.Mensagem);
        }

        public void Remover(ComentarioDTO comentario)
        {
            _comentariosRepo.Remover(comentario.ComentarioId);
        }
    }
}
