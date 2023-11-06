using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Model
{
    public class RequestLivro
    {
        public RequestLivro(int idLivro, string nomeLivro, int quantidadeEstoque) {
            id_livro = idLivro;
            nome_livro = nomeLivro;
            quantidade_estoque = quantidadeEstoque;
        }
        public int id_livro { get; set; }
        public string nome_livro { get; set; }
        public int quantidade_estoque { get; set; }
    }
}
