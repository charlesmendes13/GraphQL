using GraphQL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQL.Application.Interface
{
    public interface IAuthorService
    {
        IEnumerable<Author> GetAll();

        Author GetById(int id);

        IEnumerable<BlogPost> GetPostsByAuthor(int id);
    }
}
