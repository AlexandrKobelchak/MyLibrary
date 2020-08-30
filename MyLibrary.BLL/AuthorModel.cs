using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.BLL
{
    public class AuthorModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<BookModel> Books { get; }
    }
}
