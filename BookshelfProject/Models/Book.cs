using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookshelfProject.Models
{
    public class Book
    {
        //properties
        [Key]
        public int ID { get; set; } //this is the primary key

        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishedDate { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        [ForeignKey("Author")]
        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }

        
    }
}