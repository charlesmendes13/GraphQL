using GraphQL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQL.Domain.Interfaces.Repository
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAll();

        Author GetById(int id);

        IEnumerable<BlogPost> GetPostsByAuthor(int id);
    }
}
