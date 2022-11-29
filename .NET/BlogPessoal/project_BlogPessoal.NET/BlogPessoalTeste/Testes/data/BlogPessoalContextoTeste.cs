using System.Linq;
using BlogPessoal.src.data;
using BlogPessoal.src.modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlogPessoalTeste.Testes.data
{
    [TestClass]
    public class BlogPessoalContextoTeste
    {
        private BlogPessoalContexto _contexto;

        [TestInitialize]        
        public void inicio()
        {
            var opt = new DbContextOptionsBuilder<BlogPessoalContexto>()
            .UseInMemoryDatabase(databaseName: "db_blogpessoal")
            .Options;

            _contexto = new BlogPessoalContexto(opt);
        }

        [TestMethod]
        public void InserirNovoUsuarioNoBancoRetornaUsuario()
        {
            UsuarioModelo usuario = new UsuarioModelo();

            usuario.Nome = "Karol Boaz";
            usuario.Email = "karol@email.com";
            usuario.Senha = "134652";
            usuario.Foto = "Foto";

            _contexto.Usuarios.Add(usuario);

            _contexto.SaveChanges();

            Assert.IsNotNull(_contexto.Usuarios.FirstOrDefault(u => u.Email ==  "karol@email.com"));

        }
    }
}
