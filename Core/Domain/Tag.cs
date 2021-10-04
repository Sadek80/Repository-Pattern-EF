namespace RepositoryPattern
{
    using System.Collections.Generic;

    public class Tag
    {
        public Tag()
        {
            Courses = new HashSet<Course>();
        }

        public int TagID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
