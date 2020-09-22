﻿using GraphQL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQL.Domain.Interfaces.Repository
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> GetAll();
    }
}
