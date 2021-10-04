namespace RepositoryPattern
{
    using System.Collections.Generic;
    
    public class Course
    {
        public Course()
        {
            Tags = new HashSet<Tag>();
        }

        public int CourseID { get; set; }

        public int AuthorID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public short FullPrice { get; set; }

        public byte Level { get; set; }

        public virtual Author Author { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
