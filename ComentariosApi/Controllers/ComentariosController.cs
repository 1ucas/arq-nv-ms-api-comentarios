using ComentariosApi.Models.DTOs;
using ComentariosApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ComentariosApi.Controllers
{
    [RoutePrefix("api/Comentarios")]
    public class ComentariosController : ApiController
    {
        [HttpGet]
        [Route("usuario/{idUsuario}")]
        public List<ComentarioDTO> GetByUserId(int idUsuario)
        {
            return new ComentariosService().ListarPorUsuario(idUsuario);
        }

        [HttpGet]
        [Route("livro/{idLivro}")]
        public List<ComentarioDTO> GetByBookId(int idLivro)
        {
            return new ComentariosService().ListarPorLivro(idLivro);
        }

        [HttpPost]
        public void Post([FromBody]ComentarioDTO Comentario)
        {
            new ComentariosService().Inserir(Comentario);
        }

        [HttpDelete]
        public void Delete(ComentarioDTO Comentario)
        {
            new ComentariosService().Remover(Comentario);
        }
    }
}
