using System.Linq;
using System.Threading.Tasks;
using BlogPessoal.src.data;
using BlogPessoal.src.dtos;
using BlogPessoal.src.repositorios;
using BlogPessoal.src.repositorios.implementacoes;
using BlogPessoal.src.utilidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlogPessoalTest.Testes.repositorios
{

[TestClass]
public class UsuarioRepositorioTeste
{
    private BlogPessoalContexto _contexto;
    private IUsuario _repositorio;
    [TestInitialize]
    public void ConfiguracaoInicial()
    {
        var opt= new DbContextOptionsBuilder<BlogPessoalContexto>()
        .UseInMemoryDatabase(databaseName: "db_blogpessoal")
        .Options;
        _contexto = new BlogPessoalContexto(opt);
        _repositorio = new UsuarioRepositorio(_contexto);
    }

    [TestMethod]
    public async Task CriarQuatroUsuariosNoBancoRetornaQuatroUsuarios()
    {
        //GIVEN - Dado que registro 4 usuarios no banco
        await _repositorio.NovoUsuarioAsync(
        new NovoUsuarioDTO(
        "Gustavo Boaz",
        "gustavo@email.com",
        "134652",
        "URLFOTO",
        TipoUsuario.NORMAL));

        await _repositorio.NovoUsuarioAsync(
        new NovoUsuarioDTO(
        "Mallu Boaz",
        "mallu@email.com",
        "134652",
        "URLFOTO",
        TipoUsuario.NORMAL));

        await _repositorio.NovoUsuarioAsync(
        new NovoUsuarioDTO(
        "Catarina Boaz",
        "catarina@email.com",
        "134652",
        "URLFOTO",
        TipoUsuario.NORMAL));

        await _repositorio.NovoUsuarioAsync(
        new NovoUsuarioDTO(
        "Pamela Boaz",
        "pamela@email.com",
        "134652",
        "URLFOTO",
        TipoUsuario.NORMAL));
        //WHEN - Quando pesquiso lista total
        //THEN - Então recebo 4 usuarios
        
        Assert.AreEqual(4, _contexto.Usuarios.Count());
    }

    [TestMethod]
    public async Task PegarUsuarioPeloEmailRetornaNaoNulo()
    {
        //GIVEN - Dado que registro um usuario no banco
        await _repositorio.NovoUsuarioAsync(
        new NovoUsuarioDTO(
        "Zenildo Boaz",
        "zenildo@email.com",
        "134652",
        "URLFOTO",
        TipoUsuario.NORMAL));
        //WHEN - Quando pesquiso pelo email deste usuario
        var user = await _repositorio.PegarUsuarioPeloEmailAsync("zenildo@email.com");
        //THEN - Então obtenho um usuario
        Assert.IsNotNull(user);
    }

    [TestMethod]
    public async Task PegarUsuarioPeloIdRetornaNaoNuloENomeDoUsuario()
    {
        //GIVEN - Dado que registro um usuario no banco
        await _repositorio.NovoUsuarioAsync(
        new NovoUsuarioDTO(
        "Neusa Boaz",
        "neusa@email.com",
        "134652",
        "URLFOTO",
        TipoUsuario.NORMAL));
        //WHEN - Quando pesquiso pelo id 6
        var user = await _repositorio.PegarUsuarioPeloIdAsync(6);
        //THEN - Então, deve me retornar um elemento não nulo
        Assert.IsNotNull(user);
        //THEN - Então, o elemento deve ser Neusa Boaz
        Assert.AreEqual("Neusa Boaz", user.Nome);
    }

    [TestMethod]
    public async Task AtualizarUsuarioRetornaUsuarioAtualizado()
    {
        //GIVEN - Dado que registro um usuario no banco
        await _repositorio.NovoUsuarioAsync(
        new NovoUsuarioDTO(
        "Estefânia Boaz",
        "estefania@email.com",
        "134652",
        "URLFOTO",
        TipoUsuario.NORMAL));

        //WHEN - Quando atualizamos o usuario
            var old = 
            await _repositorio.PegarUsuarioPeloEmailAsync("estefania@email.com");
            await _repositorio.AtualizarUsuarioAsync(
            new AtualizarUsuarioDTO(
                7, 
                "Estefânia Moura", 
                "123456", 
                "URLFOTONOVA"
                ));
        //THEN - Então, quando validamos pesquisa deve retornar nome Estefânia Moura
        Assert.AreEqual(
        "Estefânia Moura",
        _contexto.Usuarios.FirstOrDefault(u => u.Id == old.Id).Nome);
        //THEN - Então, quando validamos pesquisa deve retornar senha 123456
        Assert.AreEqual(
        "123456",
        _contexto.Usuarios.FirstOrDefault(u => u.Id ==
        old.Id).Senha);
        }
    }
}