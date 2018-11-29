using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComentariosApi.Models.DTOs;

namespace ComentariosApi.Models.Interfaces
{
    public interface IComentariosService
    {
        List<ComentarioDTO> ListarPorUsuario(int idUsuario);

        List<ComentarioDTO> ListarPorLivro(int idLivro);

        void Inserir(ComentarioDTO comentario);

        void Remover(ComentarioDTO comentario);
    }
}
