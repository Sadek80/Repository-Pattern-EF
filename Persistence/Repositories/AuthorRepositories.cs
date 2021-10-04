using System.Collections.Generic;
using System.Linq;
using RepositoryPattern.Core.Repositories;
using System.Data.Entity;

namespace RepositoryPattern.Persistence.Repositories
{
    class AuthorRepositories : Repository<Author>, IAuthorRepository
    {
        public AuthorRepositories(PlutoContext context) : base(context)
        {
        }
        public IEnumerable<Author> GetAuthorsWithCourses(int count)
        {
            return plutoContext.Authors.Include(a => a.Courses).Take(count).ToList();
        }

        public PlutoContext plutoContext { get { return _context as PlutoContext; } }
    }
}
