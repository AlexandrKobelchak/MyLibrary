using MyLibrary.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary.Entities
{
    [Table("students")]
    public class Student : DbEntity
    {
        [StringLength(64)]
        [Column("firstName")]
        public string FirstName { get; set; }

        [StringLength(64)]
        [Column("lastName")]
        public string LastName { get; set; }

        [Column("groupId")]
        public Guid GroupId { get; set; }
        public Group Group { get; set; }
    }

}
