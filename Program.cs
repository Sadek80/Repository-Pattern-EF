using System;
using RepositoryPattern.Persistence;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unit = new UnitOfWork(new PlutoContext()))
            {
                var courses = unit.Courses.getTopPriceCourses(5);
                var authors = unit.Authors.GetAuthorsWithCourses(3);

                Console.WriteLine("print 5 top price courses");
                foreach (var c in courses)
                {
                    Console.WriteLine(c.Title);
                }

                Console.WriteLine();

                Console.WriteLine("Print authors with courses");
                foreach (var a in authors)
                {
                    Console.WriteLine(a.Name);
                    foreach (var c in a.Courses)
                    {
                        Console.WriteLine(c.Title);
                    }
                }
            }
        }
    }
}
