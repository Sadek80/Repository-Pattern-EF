using System.Data.Entity.ModelConfiguration;

namespace RepositoryPattern.Persistence.EntityConfiguration
{
    class CourseConfiguraiton : EntityTypeConfiguration<Course>
    {
        public CourseConfiguraiton()
        {
            Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(255);

            Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(2000);

            HasRequired(c => c.Author)
                .WithMany(a => a.Courses)
                .HasForeignKey(c => c.AuthorID);

            HasMany(e => e.Tags)
               .WithMany(e => e.Courses)
               .Map(m => m.ToTable("CourseTags").MapLeftKey("CourseId").MapRightKey("TagId"));
        }
    }
}
