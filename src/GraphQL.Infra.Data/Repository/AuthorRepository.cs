using GraphQL.Domain.Entities;
using GraphQL.Domain.Interfaces.Repository;
using GraphQL.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQL.Infra.Data.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly AppDbContext _context;

        public AuthorRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Author> GetAll()
        {
            return _context.Set<Author>().ToList();
        }

        public Author GetById(int id)
        {
            return _context.Set<Author>().Find(id);
        }

        public IEnumerable<BlogPost> GetPostsByAuthor(int id)
        {
            return _context.Set<BlogPost>().Where(x => x.AuthorId == id).ToList();
        }
    }
}
