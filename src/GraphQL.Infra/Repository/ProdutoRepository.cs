using GraphQL.Domain.Interfaces.Repository;
using GraphQL.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQL.Infra.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
