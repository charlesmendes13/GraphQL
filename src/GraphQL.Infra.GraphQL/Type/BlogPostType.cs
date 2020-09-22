using GraphQL.Types;
using GraphQL.Domain.Entities;

namespace GraphQL.Infra.Data.GraphQL.Type
{
    public class BlogPostType : ObjectGraphType<BlogPost>
    {
        public BlogPostType()
        {
            Name = "BlogPost";
            Field(_ => _.Id, type: typeof(IdGraphType)).Description("The Id of the Blog post.");
            Field(_ => _.Title).Description("The title of the blog post.");
            Field(_ => _.Content).Description("The content of the blog post.");
        }
    }
}