using MyLibrary.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary.Entities
{
    [Table("authors")]
    public class Author:DbEntity
    {   
        [StringLength(64)]
        [Column("firstName")]
        public string FirstName { get; set; }

        [StringLength(64)]
        [Column("lastName")]
        public string LastName { get; set; }

        public List<BookAuthor> BookAuthor { get; set; }
    }

}
