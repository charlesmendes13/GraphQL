using GraphQL.Domain.Entities;
using System.Collections.Generic;

namespace GraphQL.Application.Interface
{
    public interface IAuthorService
    {
        IEnumerable<Author> GetAll();

        Author GetById(int id);

        IEnumerable<BlogPost> GetPostsByAuthor(int id);
    }
}
