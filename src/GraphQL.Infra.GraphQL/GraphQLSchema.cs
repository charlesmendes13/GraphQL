using GraphQL.Types;
using GraphQL.Infra.Data.GraphQL.Queries;

namespace GraphQL.Infra.Data.GraphQL
{
    public class GraphQLSchema : Schema, ISchema
    {
        public GraphQLSchema(IDependencyResolver
        resolver) : base(resolver)
        {
            Query = resolver.Resolve<AuthorQuery>();
        }
    }
}
