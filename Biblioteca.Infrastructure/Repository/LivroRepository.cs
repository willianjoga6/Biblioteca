using Biblioteca.Domain.Interface;
using Biblioteca.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infrastructure.Repository
{
    public class LivroRepository : ILivroRepository
    {
        public async Task<ResponseGetLivro> ConsultaLivroRepository()
        {
			try
			{
				var teste = new ResponseGetLivro();
				teste.IdLivro = 1;
				teste.NomeLivro = "TesteNome";
				teste.QuantidadeTotal= 10;
				teste.QuantidadeDisponível= 7;

				return await Task.FromResult(teste);

			}
			catch (Exception)
			{
				throw;
			}
        }
    }
}
