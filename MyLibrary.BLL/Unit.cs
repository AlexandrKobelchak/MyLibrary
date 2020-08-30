using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MyLibrary.Context;
using MyLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.BLL
{
    public static class Unit
    {
        static Unit()
        {
            Context = new MyAppDbContext(
                new DbContextOptionsBuilder<MyAppDbContext>()
                    .UseSqlServer(new SqlConnectionStringBuilder
                    {
                        DataSource = "127.0.0.1",
                        InitialCatalog = "Univercity",
                        IntegratedSecurity = true
                    }.ConnectionString)
                    .Options);

            Context.Database.EnsureDeleted();
            Context.Database.EnsureCreated();

            AuthorRepository = new AuthorRepository(Context);
            BookRepository = new BookRepository(Context);
            CategoryRepository = new CategoryRepository(Context);
            DepartmentRepository = new DepartmentRepository(Context);
            ECardRepository = new ECardsRepository(Context);
            EmployeeRepository = new EmploeeRepository(Context);
            FacultyRepository = new FacultyRepository(Context);
            GroupRepository = new GroupRepository(Context);
            LibrarianRepository = new LibrarianRepository(Context);
            PressRepository = new PressRepository(Context);
            SCardRepository = new SCardsRepository(Context);
            StudentRepository = new StudentRepository(Context);
            ThemeRepository = new ThemeRepository(Context);
        }

        public static MyAppDbContext Context { get; }
        public static IAuthorRepository AuthorRepository { get; }
        public static IBookRepository BookRepository { get; }
        public static ICategoryRepository CategoryRepository { get; }
        public static IDepartmentRepository DepartmentRepository { get; }
        public static IECardRepository ECardRepository { get; }
        public static IEmployeeRepository EmployeeRepository { get; }
        public static IFacultyRepository FacultyRepository { get; }
        public static IGroupRepository GroupRepository { get; }
        public static ILibrarianRepository LibrarianRepository { get; }
        public static IPressRepository PressRepository { get; }
        public static ISCardRepository SCardRepository { get; }
        public static IStudentRepository StudentRepository { get; }
        public static IThemeRepository ThemeRepository { get; }
    }
}
