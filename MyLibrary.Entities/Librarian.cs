using MyLibrary.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Entities
{
    [Table("libs")]
    public class Librarian : DbEntity
    {
        [StringLength(64)]
        [Column("firstName")]
        public string FirstName { get; set; }

        [StringLength(64)]
        [Column("lastName")]
        public string LastName { get; set; }

        public List<SCard> SCards { get; set; }
        public List<ECard> ECards { get; set; }
    }
}
