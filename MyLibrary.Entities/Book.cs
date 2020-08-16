using MyLibrary.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary.Entities
{
    [Table("books")]
    public class Book:DbEntity
    {        
        [StringLength(64)]
        [Column("name")]
        public string Name { get; set; }

        public Theme Theme { get; set; }

        [Column("themeId")]
        public Guid ThemeId { get; set; }

        public Press Press { get; set; }

        [Column("pressId")]
        public Guid PressId { get; set; }

        public Category Category { get; set; }

        [Column("categoryId")]
        public Guid CategoryId { get; set; }

        public List<BookAuthor> BookAuthor { get; set; }
    }

}
