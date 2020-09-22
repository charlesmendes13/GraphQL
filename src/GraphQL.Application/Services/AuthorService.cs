using GraphQL.Application.Interface;
using GraphQL.Domain.Entities;
using GraphQL.Domain.Interfaces.Repository;
using System.Collections.Generic;

namespace GraphQL.Application.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public IEnumerable<Author> GetAll()
        {
            return _authorRepository.GetAll();
        }

        public Author GetById(int id)
        {
            return _authorRepository.GetById(id);
        }

        public IEnumerable<BlogPost> GetPostsByAuthor(int id)
        {
            return _authorRepository.GetPostsByAuthor(id);
        }
    }
}
