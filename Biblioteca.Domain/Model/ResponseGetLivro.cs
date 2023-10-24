using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Model
{
    public class ResponseGetLivro
    {
        public int IdLivro { get; set; }
        public string NomeLivro { get; set; }
        public int QuantidadeTotal { get; set; }
        public int QuantidadeDisponível { get; set; }
    }
}
