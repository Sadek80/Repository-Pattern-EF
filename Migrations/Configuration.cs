namespace RepositoryPattern.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal sealed class Configuration : DbMigrationsConfiguration<RepositoryPattern.PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RepositoryPattern.PlutoContext context)
        {
            #region Add Tags
            var tags = new Dictionary<string, Tag>
            {
                {"c#", new Tag {TagID = 1, Name = "c#"}},
                {"angularjs", new Tag {TagID = 2, Name = "angularjs"}},
                {"javascript", new Tag {TagID = 3, Name = "javascript"}},
                {"nodejs", new Tag {TagID = 4, Name = "nodejs"}},
                {"oop", new Tag {TagID = 5, Name = "oop"}},
                {"linq", new Tag {TagID = 6, Name = "linq"}},
            };

            foreach (var tag in tags.Values)
                context.Tags.AddOrUpdate(t => t.TagID, tag);
            #endregion

            #region Add Authors
            var authors = new List<Author>
            {
                new Author
                {
                    AuthorID = 1,
                    Name = "Mosh Hamedani"
                },
                new Author
                {
                    AuthorID = 2,
                    Name = "Anthony Alicea"
                },
                new Author
                {
                    AuthorID = 3,
                    Name = "Eric Wise"
                },
                new Author
                {
                    AuthorID = 4,
                    Name = "Tom Owsiak"
                },
                new Author
                {
                    AuthorID = 5,
                    Name = "John Smith"
                }
            };

            foreach (var author in authors)
                context.Authors.AddOrUpdate(a => a.AuthorID, author);
            #endregion

            #region Add Courses
            var courses = new List<Course>
            {
                new Course
                {
                    CourseID = 1,
                    Title = "C# Basics",
                    AuthorID = 1,
                    FullPrice = 49,
                    Description = "Description for C# Basics",
                    Level = 1,
                    Tags = new Collection<Tag>()
                    {
                        tags["c#"]
                    }
                },
                new Course
                {
                    CourseID = 2,
                    Title = "C# Intermediate",
                    AuthorID = 1,
                    FullPrice = 49,
                    Description = "Description for C# Intermediate",
                    Level = 2,
                    Tags = new Collection<Tag>()
                    {
                        tags["c#"],
                        tags["oop"]
                    }
                },
                new Course
                {
                    CourseID = 3,
                    Title = "C# Advanced",
                    AuthorID = 1,
                    FullPrice = 69,
                    Description = "Description for C# Advanced",
                    Level = 3,
                    Tags = new Collection<Tag>()
                    {
                        tags["c#"]
                    }
                },
                new Course
                {
                    CourseID = 4,
                    Title = "Javascript: Understanding the Weird Parts",
                    AuthorID = 2,
                    FullPrice = 149,
                    Description = "Description for Javascript",
                    Level = 2,
                    Tags = new Collection<Tag>()
                    {
                        tags["javascript"]
                    }
                },
                new Course
                {
                    CourseID = 5,
                    Title = "Learn and Understand AngularJS",
                    AuthorID = 2,
                    FullPrice = 99,
                    Description = "Description for AngularJS",
                    Level = 2,
                    Tags = new Collection<Tag>()
                    {
                        tags["angularjs"]
                    }
                },
                new Course
                {
                    CourseID = 6,
                    Title = "Learn and Understand NodeJS",
                    AuthorID = 2,
                    FullPrice = 149,
                    Description = "Description for NodeJS",
                    Level = 2,
                    Tags = new Collection<Tag>()
                    {
                        tags["nodejs"]
                    }
                },
                new Course
                {
                    CourseID = 7,
                    Title = "Programming for Complete Beginners",
                    AuthorID = 3,
                    FullPrice = 45,
                    Description = "Description for Programming for Beginners",
                    Level = 1,
                    Tags = new Collection<Tag>()
                    {
                        tags["c#"]
                    }
                },
                new Course
                {
                    CourseID = 8,
                    Title = "A 16 Hour C# Course with Visual Studio 2013",
                    AuthorID = 4,
                    FullPrice = 150,
                    Description = "Description 16 Hour Course",
                    Level = 1,
                    Tags = new Collection<Tag>()
                    {
                        tags["c#"]
                    }
                },
                new Course
                {
                    CourseID = 9,
                    Title = "Learn JavaScript Through Visual Studio 2013",
                    AuthorID = 4,
                    FullPrice = 20,
                    Description = "Description Learn Javascript",
                    Level = 1,
                    Tags = new Collection<Tag>()
                    {
                        tags["javascript"]
                    }
                }
            };

            foreach (var course in courses)
                context.Courses.AddOrUpdate(c => c.CourseID, course);
            #endregion
        }
    }
}
