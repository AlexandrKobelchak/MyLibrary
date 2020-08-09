using MyLibrary.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDomain.Entities
{
    [Table("eCards")]
    public class ECard : DBEntity
    {
        public Book Book { get; set; }
        public Librarian Librarian { get; set; }
        public Employee Employer { get; set; }

        [Column("dateOut")]
        public DateTime DateOut { get; set; } = DateTime.Now;

        [Column("dateIn")]
        public DateTime? DateIn { get; set; }
    }
}
