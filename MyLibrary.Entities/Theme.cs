using MyLibrary.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataDomain.Entities
{
    [Table("themes")]
    public class Theme : DBEntity
    {   
        [StringLength(64)]
        [Column("name")]
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }

}
