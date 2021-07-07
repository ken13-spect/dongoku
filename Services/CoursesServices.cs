using System.Collections.Generic;
using System.Linq;
using AppUCA.Context;
using AppUCA.Entities;
using AppUCA.Repository;

namespace AppUCA.Services
{
    public class CoursesServices : IRepository<Course>
    {
        private AppGuiContext _context;

        public CoursesServices()
        {
            _context = new AppGuiContext();
        }
        
        public List<Course> GetAll()
        {
            return _context.Courses.ToList();
        }

        public void Create(Course item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Delete(Course item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }
    }
}