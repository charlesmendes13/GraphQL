using GraphQL.Domain.Entities;
using GraphQL.Domain.Interfaces.Repository;
using GraphQL.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQL.Infra.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> GetAll() => _context.Categorias.ToList();
    }
}
