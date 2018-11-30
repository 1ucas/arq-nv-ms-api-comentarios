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

        /// <summary>
        /// Obtem comentário por ID de Usuário.
        /// </summary>
        /// <remarks>
        /// Exemplo de entrada:
        /// 
        ///     {
        ///         "idUsuario": 1
        ///     }
        ///     
        /// </remarks>
        /// <param name="idUsuario">ID referente ao usuário.</param>
        [HttpGet]
        [Route("usuario/{idUsuario}")]
        public List<ComentarioDTO> GetByUserId(int idUsuario)
        {
            return _comentariosService.ListarPorUsuario(idUsuario);
        }

        /// <summary>
        /// Obtem Livro por ID.
        /// </summary>
        /// <remarks>
        /// Exemplo de entrada:
        /// 
        ///     {
        ///         "idLivro": 1
        ///     }
        ///     
        /// </remarks>
        /// <param name="idLivro">ID referente ao Livro.</param>
        [HttpGet]
        [Route("livro/{idLivro}")]
        public List<ComentarioDTO> GetByBookId(int idLivro)
        {
            return _comentariosService.ListarPorLivro(idLivro);
        }

        /// <summary>
        /// Salva um novo comentário.
        /// </summary>       
        /// <param name="Comentario">Objeto que contém informações sobre o Comentário.</param>
        [HttpPost]
        public void Post([FromBody]ComentarioDTO Comentario)
        {
            _comentariosService.Inserir(Comentario);
        }

        /// <summary>
        /// Deleta um Comentário.
        /// </summary>
        /// <param name="Comentario">Objeto que contém informações sobre o Comentário.</param>
        [HttpDelete]
        public void Delete(ComentarioDTO Comentario)
        {
            _comentariosService.Remover(Comentario);
        }
    }
}
