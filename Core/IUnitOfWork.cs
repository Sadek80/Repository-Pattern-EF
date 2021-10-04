using System;
using RepositoryPattern.Core.Repositories;

namespace RepositoryPattern.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; set; }
        IAuthorRepository Authors { get; set; }

        int Complete();

    }
}
