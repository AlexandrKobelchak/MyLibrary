using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.ViewModels
{
    public class BookVM
    {
        public Guid Id { get; set; }
        public string BookName { get; set; }
        public string PressName { get; set; }
        public string CategoryName { get; set; }
        public string ThemeName { get; set; }
        public List<AuthorVM> Authors { get; set; }

    }
}
