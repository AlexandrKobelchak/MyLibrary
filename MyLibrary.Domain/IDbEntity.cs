using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary.Domain
{
    public interface IDbEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
