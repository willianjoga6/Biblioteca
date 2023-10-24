using Biblioteca.Domain.Model;

namespace Biblioteca.Domain.Interface
{
    public interface ILivroConsulta
    {
        Task<ResponseGetLivro> ConsultaLivro();
    }
}