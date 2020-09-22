using Microsoft.EntityFrameworkCore;
using GraphQL.Domain.Entities;

namespace GraphQL.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Author> Author { get; set; }
        public DbSet<BlogPost> BlogPost { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    FirstName = "Charles",
                    LastName = "Mendes"
                });

            modelBuilder.Entity<Author>().HasData(
               new Author
               {
                   Id = 2,
                   FirstName = "Vitor",
                   LastName = "Gorni"
               });

            modelBuilder.Entity<BlogPost>().HasData(
                new BlogPost
                {
                    Id = 1,
                    Title = "The Beatles",
                    Content = "A maior banda do Mundo",
                    AuthorId = 1
                });

            modelBuilder.Entity<BlogPost>().HasData(
                new BlogPost
                {
                    Id = 2,
                    Title = "O Codigo Binário",
                    Content = "Tudo sobre o incrível universo dos bits",
                    AuthorId = 1
                });            

            modelBuilder.Entity<BlogPost>().HasData(
                new BlogPost
                {
                    Id = 3,
                    Title = "OAB Tributário",
                    Content = "Como ser aprovado de primeira",
                    AuthorId = 2
                });

            modelBuilder.Entity<BlogPost>().HasData(
                new BlogPost
                {
                    Id = 4,
                    Title = "Obras a beira-mar",
                    Content = "Vai fazer uma obra antes de casar?",
                    AuthorId = 2
                });

            modelBuilder.Entity<BlogPost>().HasData(
                new BlogPost
                {
                    Id = 5,
                    Title = "Xbox, PS4 e PC",
                    Content = "Saiba tudo e mais um pouco sobre games",
                    AuthorId = 2
                });
        }        
    }
}
