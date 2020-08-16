using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary.Entities
{
    [Table("books_authors")]
    public class BookAuthor
    {
        [Column("bookId")]
        public Guid BookId { get; set; }

        [Column("authorId")]
        public Guid AuthorId { get; set; }

        public Book Book { get; set; }
        public Author Author { get; set; }
    }

}
