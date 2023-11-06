using Biblioteca.Domain.Interface;
using Biblioteca.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Application.ViewModel;
using Biblioteca.Application.Mappers;

namespace Biblioteca.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BibliotecaController : Controller
    {
        private readonly ILivro _ILivro;

        public BibliotecaController(ILivro iLivro)
        {
            _ILivro = iLivro;
        }

        [HttpGet(Name = "Consultar")]
        public List<ResponseGetLivro> Consultar([FromQuery] int IdLivro)
        {
            try
            {

                var teste = _ILivro.GetLivro(IdLivro);

                return teste;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost(Name = "Inserir")]
        public ResponseInserirLivro Inserir([FromBody] RequestLivroVM requestLivroVM)
        {
            try
            {
                var inserirLivro = RequestLivroMapper.ToRequestLivro(requestLivroVM);

                var retornoLivro = _ILivro.InserirLivro(inserirLivro);

                return retornoLivro;
            }
            catch (Exception)
            {
                throw;
            }            
        }
    }
}
