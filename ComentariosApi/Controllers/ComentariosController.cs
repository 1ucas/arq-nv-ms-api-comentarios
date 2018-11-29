using System.Collections.Generic;
using System.Web.Http;
using ComentariosApi.Models.DTOs;
using ComentariosApi.Models.Interfaces;

namespace ComentariosApi.Controllers
{
    [RoutePrefix("api/v1/Comentarios")]
    public class ComentariosController : ApiController
    {
        private readonly IComentariosService _comentariosService;
        public ComentariosController(IComentariosService comentariosService)
        {
            _comentariosService = comentariosService;
        }

        [HttpGet]
        [Route("usuario/{idUsuario}")]
        public List<ComentarioDTO> GetByUserId(int idUsuario)
        {
            return _comentariosService.ListarPorUsuario(idUsuario);
        }

        [HttpGet]
        [Route("livro/{idLivro}")]
        public List<ComentarioDTO> GetByBookId(int idLivro)
        {
            return _comentariosService.ListarPorLivro(idLivro);
        }

        [HttpPost]
        public void Post([FromBody]ComentarioDTO Comentario)
        {
            _comentariosService.Inserir(Comentario);
        }

        [HttpDelete]
        public void Delete(ComentarioDTO Comentario)
        {
            _comentariosService.Remover(Comentario);
        }
    }
}
