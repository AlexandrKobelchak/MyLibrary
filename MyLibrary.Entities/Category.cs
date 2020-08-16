using MyLibrary.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary.Entities
{
    [Table("categories")]
    public class Category : DbEntity
    {
        
        [StringLength(64)]
        [Column("name")]
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
