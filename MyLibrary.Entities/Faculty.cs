using MyLibrary.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary.Entities
{
    [Table("faculties")]
    public class Faculty : DbEntity
    {
       
        [StringLength(64)]
        [Column("facultyName")]
        public string Name { get; set; }
        public List<Group> Groups { get; set; }
    }
}
