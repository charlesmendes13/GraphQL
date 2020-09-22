using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraphQL.Domain.Entities
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        
        public string FirstName { get; set; }
       
        public string LastName { get; set; }

        public ICollection<BlogPost> BlogPost { get; set; }
    }
}
