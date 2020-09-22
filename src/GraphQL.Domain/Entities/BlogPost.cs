using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQL.Domain.Entities
{    
    public class BlogPost
    {
        [Key]       
        public int Id { get; set; }
        
        public string Title { get; set; }
       
        public string Content { get; set; }

        [Column("AuthorId")]
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
