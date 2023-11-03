using Biblioteca.Domain.Interface;
using Biblioteca.Domain.Model;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet(Name = "ConsultarLivro")]
        public async Task<List<ResponseGetLivro>> ConsultarLivro([FromQuery] int IdLivro) 
        {
            try
            {

                var teste = _ILivro.GetLivro(IdLivro);

                return await teste;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
