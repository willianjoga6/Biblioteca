using Biblioteca.Domain.Model;

namespace Biblioteca.Domain.Interface
{
    public interface ILivroRepository
    {
        Task<ResponseGetLivro> ConsultaLivroRepository();
    }
}