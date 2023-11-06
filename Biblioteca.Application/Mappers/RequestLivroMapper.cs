using Biblioteca.Application.ViewModel;
using Biblioteca.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Application.Mappers
{
    public class RequestLivroMapper
    {
        public static RequestLivro ToRequestLivro(RequestLivroVM requestLivroVW)
        { 
            var inserirLivro = new RequestLivro(
                requestLivroVW.id_livro,
                requestLivroVW.nome_livro,
                requestLivroVW.quantidade_estoque);

            return inserirLivro;
        }
    }
}
