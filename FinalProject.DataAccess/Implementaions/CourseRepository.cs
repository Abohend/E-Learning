using Learn.DataAccess.Data;
using Learn.Entities.Models;
using Learn.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DataAccess.Implementaions
{

    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        private readonly AppDbContext _context;
        public CourseRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Course course)
        {
            var courseInDb = _context.Courses.FirstOrDefault(x => x.Id == course.Id);
            if (courseInDb is not null)
            {
                courseInDb.Id = course.Id;
                courseInDb.Name = course.Name;
                courseInDb.Description = course.Description;
                courseInDb.Price = course.Price;
                courseInDb.CategoryId = course.CategoryId;
            }
        }
    }
}
