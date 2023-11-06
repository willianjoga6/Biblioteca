using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Application.ViewModel
{
    public class RequestLivroVM
    {
        public int id_livro { get; set; }
        public string nome_livro { get; set; }
        public int quantidade_estoque { get; set; }
    }
}
