using RepositoryPattern.Core;
using RepositoryPattern.Core.Repositories;
using RepositoryPattern.Persistence.Repositories;

namespace RepositoryPattern.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext _context;

        public UnitOfWork(PlutoContext context)
        {
            this._context = context;

            Courses = new CourseRepository(_context);
            Authors = new AuthorRepositories(_context);
        }

        public ICourseRepository Courses { get; set; }
        public IAuthorRepository Authors { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
