using System;
using System.Collections.Generic;
using ComentariosApi.Models.Entidades;
using ComentariosApi.Models.Interfaces;
using ComentariosApi.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ComentariosApi.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListarPorUsuario_CaminhoFeliz_ListaComentarios()
        {
            int idUsuario = 1;
            Mock<IComentariosRepo> mock = new Mock<IComentariosRepo>();
            mock.Setup(m => m.ListarPorUsuario(idUsuario)).Returns(
                new List<ComentarioEntidade>()
                {
                    new ComentarioEntidade()
                    {
                        UsuarioId = idUsuario,
                        LivroIsbn = 1,
                        Mensagem = "Otimo Livro",
                        Avaliacao = 5
                    }
                }
            );
            ComentariosService _comentariossService = new ComentariosService(mock.Object);

            var result = _comentariossService.ListarPorUsuario(idUsuario);

            Assert.AreEqual(result.Count, 1);
        }

        public void ListarPorLivro_CaminhoFeliz_ListaComentarios()
        {
            int idLivro = 1;
            Mock<IComentariosRepo> mock = new Mock<IComentariosRepo>();
            mock.Setup(m => m.ListarPorLivro(idLivro)).Returns(
                new List<ComentarioEntidade>()
                {
                    new ComentarioEntidade()
                    {
                        UsuarioId = idLivro,
                        LivroIsbn = 1,
                        Mensagem = "Otimo Livro",
                        Avaliacao = 5
                    }
                }
            );
            ComentariosService _comentariossService = new ComentariosService(mock.Object);

            var result = _comentariossService.ListarPorUsuario(idLivro);

            Assert.AreEqual(result.Count, 1);
        }
    }
}
