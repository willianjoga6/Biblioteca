using Biblioteca.Domain.Interface;
using Biblioteca.Domain.Model;
using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Biblioteca.Infrastructure.Repository
{
    public class LivroRepository : ILivroRepository
    {
		private readonly IConexaoDB _conexaoDB;
        private readonly string _stringConexao;

        public LivroRepository(IConexaoDB conexaoDB)
        {
            _conexaoDB = conexaoDB;
            _stringConexao = _conexaoDB.GetConexao();            
        }

        public List<ResponseGetLivro> ConsultarLivroRepository(int idLivro)
        {
			try
			{
				List<ResponseGetLivro> listaLivros = new List<ResponseGetLivro>();

                using var _conn = new MySqlConnection(_stringConexao);

                var query = "" +
                    "SELECT " + 
	                    "a.id_livro, "+
                        "a.nome_livro, "+
                        "b.quantidade_estoque, "+
                        "c.quantidade_emprestimo "+   
                        "FROM biblioteca.livros a "+
                    "inner join biblioteca.livros_estoques b on (a.id_livro = b.id_livro) "+
                    "inner join biblioteca.livros_estoques_emprestimos c on (a.id_livro = c.id_livro) "+
                    "";
                var queryParam = query + "Where a.id_livro = @idLivro";

                var select = (idLivro > 0) ? _conn.Query<ResponseGetLivro>(queryParam, new { idLivro }) : _conn.Query<ResponseGetLivro>(query);

                foreach (var i in select)
                {
                    var retornoLivro = new ResponseGetLivro(
                        i.id_livro, 
                        i.nome_livro, 
                        i.quantidade_estoque, 
                        (i.quantidade_estoque-i.quantidade_emprestimo));

                    listaLivros.Add(retornoLivro);
                }					

                return listaLivros;
			}
			catch (Exception)
			{
				throw;
			}
        }

        public void InserirLivro(RequestLivro requestLivro)
        {
            try
            {
                using var _conn = new MySqlConnection(_stringConexao);

                var query = "INSERT INTO biblioteca.livros (id_livro, nome_livro) " +
                    "VALUES (@idLivro, @nomeLivro)";

                var insert = _conn.Execute(query, new {
                        requestLivro.id_livro, 
                        requestLivro.nome_livro 
                        }
                    );

            }
            catch (Exception)
            {
                throw;
            }                       
        }
    }
}
