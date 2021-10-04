using System.Collections.Generic;
using System.Linq;
using RepositoryPattern.Core.Repositories;
using System.Data.Entity;

namespace RepositoryPattern.Persistence.Repositories
{
    class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(PlutoContext context) : base(context)
        {
        }
        public IEnumerable<Course> getCoursesWithAuthors(int pageIndex, int pageSize)
        {
            return plutoContext.Courses
                .Include(c => c.Author)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public IEnumerable<Course> getTopPriceCourses(int count)
        {
            return plutoContext.Courses
                .OrderByDescending(c => c.FullPrice)
                .Take(count)
                .ToList();
        }

        public PlutoContext plutoContext { get { return _context as PlutoContext; } }
    }
}
