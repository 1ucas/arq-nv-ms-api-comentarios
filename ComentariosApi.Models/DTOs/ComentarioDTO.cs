using ComentariosApi.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComentariosApi.Models.DTOs
{
    public class ComentarioDTO
    {
        public string ComentarioId { get; set; }
        public int UsuarioId { get; set; }
        public int LivroIsbn { get; set; }
        public int Avaliacao { get; set; }
        public string Mensagem { get; set; }

        public static List<ComentarioDTO> From(List<ComentarioEntidade> listaComentarios)
        {
            var listaComentariosDTO = new List<ComentarioDTO>();
            foreach (var Comentario in listaComentarios)
            {
                listaComentariosDTO.Add(new ComentarioDTO
                {
                    ComentarioId = Comentario.Id.ToString(),
                    LivroIsbn = Comentario.LivroIsbn,
                    UsuarioId = Comentario.UsuarioId,
                    Avaliacao = Comentario.Avaliacao,
                    Mensagem = Comentario.Mensagem
                });
            }
            return listaComentariosDTO;
        }
    }
}
