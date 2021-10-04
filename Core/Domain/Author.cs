namespace RepositoryPattern
{
    using System.Collections.Generic;

    public class Author
    {
        public Author()
        {
            Courses = new HashSet<Course>();
        }

        public int AuthorID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
