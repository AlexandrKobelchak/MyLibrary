using MyLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using MyLibrary.ViewModels;

namespace MyLibrary.BLL
{
    public class BookModel
    {
        public Guid Id { get; set; }
        public Guid ThemeId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid PressId { get; set; }
        public string BookName { get; set; }
        public string PressName { get; set; }
        public string CategoryName { get; set; }
        public string ThemeName { get; set; }
        public List<AuthorModel> Authors { get; }

        public BookModel(Book book)
        {
            Id = book.Id;
            CategoryId = book.CategoryId;
            PressId = book.PressId;
            ThemeId = book.ThemeId;
            BookName = book.Name;
            PressName = book.Press.Name;
            CategoryName = book.Category.Name;
            ThemeName = book.Theme.Name;
            Authors = book.BookAuthor
                .Select(ba => new AuthorModel
                {
                    Id=ba.Author.Id,
                    FirstName = ba.Author.FirstName,
                    LastName = ba.Author.LastName
                }).ToList();
        }
        public static implicit operator BookVM(BookModel model)
        {
            return new BookVM
            {
                BookName = model.BookName,
                CategoryName = model.CategoryName,
                ThemeName = model.ThemeName,
                PressName = model.PressName,
                Authors = model.Authors.Select(
                    a => new AuthorVM {
                        Id = a.Id,
                        FirstName=a.FirstName,
                        LastName=a.LastName
                    }).ToList()
            };
        }

        public static IEnumerable<BookModel> GetAllBooks()
        {
            return Unit.BookRepository.AllItems
                .Include(b => b.Theme)
                .Include(b=>b.Press)
                .Include(b=>b.Category)
                .Include(b=>b.BookAuthor).ThenInclude(ba=>ba.Author)
                .Select(b => new BookModel(b))
                .ToList();
        }
        public static IEnumerable<BookVM> GetAllBookVM()
        {
            return Unit.BookRepository.AllItems
                .Include(b => b.Theme)
                .Include(b => b.Press)
                .Include(b => b.Category)
                .Include(b => b.BookAuthor).ThenInclude(ba => ba.Author)
                .Select(b => (BookVM) new BookModel(b))
                .ToList();
        }
    }
}
