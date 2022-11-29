using System.Collections.Generic;
using System.Threading.Tasks;
using BlogPessoal.src.dtos;
using BlogPessoal.src.modelos;
/// <summary>
/// <para>Resumo: Responsavel por representar ações de CRUD de tema</para>
/// <para>Criado por: Michelli Cordeiro </para>
/// <para>Versão: 1.0 </para>
/// <para>Data: 29/04/2022</para>
/// </summary>
public interface ITema
    {
        Task NovoTemaAsync(NovoTemaDTO tema);
        Task AtualizarTemaAsync(AtualizarTemaDTO tema);
        Task DeletarTemaAsync(int id);
        Task<TemaModelo> PegarTemaPeloIdAsync(int Id);
        Task<List<TemaModelo>> PegarTemaPelaDescricaoAsync(string descricao);
        Task<List<TemaModelo>> PegarTodosTemasAsync();
    }