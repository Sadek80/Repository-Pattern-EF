using System.Collections.Generic;

namespace RepositoryPattern.Core.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IEnumerable<Author> GetAuthorsWithCourses(int count);
    }
}
