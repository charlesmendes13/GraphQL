using GraphiQl;
using GraphQL.Types;
using GraphQL.Http;
using GraphQL.Application.Interface;
using GraphQL.Application.Services;
using GraphQL.Infra.Data.Context;
using GraphQL.Infra.Data.GraphQL;
using GraphQL.Infra.Data.GraphQL.Queries;
using GraphQL.Infra.Data.GraphQL.Type;
using GraphQL.Infra.Data.Repository;
using GraphQL.Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
 
namespace GraphQL.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Context

            services.AddDbContextPool<AppDbContext>(option =>
                 option.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );

            // GraphQL

            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.AddScoped<IDocumentExecuter, DocumentExecuter>();
            services.AddScoped<IDocumentWriter, DocumentWriter>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();                     
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<AuthorQuery>();
            services.AddScoped<AuthorType>();
            services.AddScoped<BlogPostType>();
            services.AddScoped<ISchema, GraphQLSchema>();

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            // GraphQL

            app.UseGraphiQl();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
