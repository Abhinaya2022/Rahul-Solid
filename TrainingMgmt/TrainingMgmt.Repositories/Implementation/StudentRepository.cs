using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingMgmt.Repositories.Interfaces;
using TrainingMgmt.Repositories.Models;

namespace TrainingMgmt.Repositories.Implementation
{
    public class StudentRepository : IStudentRepository
    {
        public Student Add(Student student)
        {
            ManagementContext context = new ManagementContext();
            context.Students.Add(student);
            context.SaveChanges();
            return student;
        }

        public Student GetById(int id)
        {
            ManagementContext context = new ManagementContext();
            return context.Students.Find(id);
        }

        public List<Student> GetList()
        {
            ManagementContext context = new ManagementContext();
            return context.Students.ToList();
        }

        public Student Update(Student student)
        {
            ManagementContext context = new ManagementContext();
            context.Students.Update(student);
            context.SaveChanges();
            return student;
        }

        public bool Delete(int id)
        {
            ManagementContext context = new ManagementContext();
            Student student = context.Students.Find(id);
            context.Students.Remove(student);
            context.SaveChanges();
            return true;
        }        
    }
}
