using System.Collections.Generic;

namespace RepositoryPattern.Core.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> getTopPriceCourses(int count);
        IEnumerable<Course> getCoursesWithAuthors(int pageIndex, int pageSize);
    }
}
