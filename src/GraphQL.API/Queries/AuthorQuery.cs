using GraphQL.API.Type;
using GraphQL.Application.Interface;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.API.Queries
{
    public class AuthorQuery : ObjectGraphType
    {
        public AuthorQuery(IAuthorService authorService)
        {
            int id = 0;

            Field<ListGraphType<AuthorType>>(name: "authors", resolve: context =>
            {
                return authorService.GetAll();
            });

            Field<AuthorType>(name: "author", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }), resolve: context =>
            {
                id = context.GetArgument<int>("id");
                return authorService.GetById(id);
            });

            Field<ListGraphType<BlogPostType>>(name: "blogs", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }), resolve: context =>
            {
                return authorService.GetPostsByAuthor(id);
            });
        }
    }
}
