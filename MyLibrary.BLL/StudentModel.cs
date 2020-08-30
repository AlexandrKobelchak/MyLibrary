using MyLibrary.Entities;
using MyLibrary.Repositories;
using MyLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace MyLibrary.BLL
{
    public class StudentModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public string GroupName { get; set; }
        public Guid GroupId { get; set; }

        public StudentModel(Student student)
        {
            Id = student.Id;
            FirstName = student.FirstName;
            LastName = student.LastName;
            GroupId = student.GroupId;
            GroupName = student.Group.Name;
        }
        public static implicit operator StudentVM(StudentModel model)
        {
            return new StudentVM { 
                FirstName = model.FirstName,
                LastName =model.LastName,
                GroupName=model.GroupName
            };
        }

        public static IEnumerable<StudentModel> GetAllStudents()
        {
            return Unit.StudentRepository.AllItems
                .Include(s => s.Group)
                .Select(s => new StudentModel(s))
                .ToList();
        }
    }
}
