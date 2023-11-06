using Biblioteca.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Model
{
    public class ResponseInserirLivro
    {
        public ResponseInserirLivro(string teste)
        {
            Teste = teste;
        }

        public string Teste { get; set; }

    }
}
