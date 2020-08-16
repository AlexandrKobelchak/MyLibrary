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
    [Table("employees")]
    public class Employee :DbEntity
    {
        [Column("firstName")]
        [StringLength(64)]
        public string FirstName { get; set; }

        [Column("lastName")]
        [StringLength(64)]
        public string LastName { get; set; }

        [Column("middleName")]
        [StringLength(64)]
        public string MiddleName { get; set; }

        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }

        [Column("address")]
        [StringLength(255)]
        public string Address { get; set; }
        public Department Department { get; set; }

    }
}
