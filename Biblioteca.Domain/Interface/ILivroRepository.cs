﻿using Biblioteca.Domain.Model;

namespace Biblioteca.Domain.Interface
{
    public interface ILivroRepository
    {
        List<ResponseGetLivro> ConsultarLivroRepository(int idLivro);
        public void InserirLivro(RequestLivro requestLivro);
    }
}