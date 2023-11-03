using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Domain.Interface;

namespace Biblioteca.Domain.Model
{
    public class ResponseGetLivro
    {
        public ResponseGetLivro() { }
        public ResponseGetLivro(int idLivro, string nomeLivro, int quantidadeTotal, int quantidadeDisponivel) {
            id_livro = idLivro;
            nome_livro = nomeLivro;
            quantidade_estoque = quantidadeTotal;
            quantidade_emprestimo = quantidadeDisponivel;
        }

        [DisplayName("Id do Livro")]        
        public int id_livro { get; set; }
        [DisplayName ("Nome do Livro")]
        public string nome_livro { get; set; }
        [DisplayName ("Quantidade em Estoque")]
        public int quantidade_estoque { get; set; }
        [DisplayName ("Quantidade Disponível")]
        public int quantidade_emprestimo { get; set; }
    }
}
