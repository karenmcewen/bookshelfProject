using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookshelfProject.Models
{
    public class Author
    {
        [Key]
        public int ID { get; set; }
        public string AuthorName { get; set; }
        public virtual ICollection<Book> Books { get; set; }

             
       
    }
}