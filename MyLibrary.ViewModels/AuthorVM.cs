using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.ViewModels
{
    public class AuthorVM
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<BookVM> Books { get; set; }
    }
}
