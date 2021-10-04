using System.Data.Entity.ModelConfiguration;

namespace RepositoryPattern.Persistence.EntityConfiguration
{
    class AuthorConfiguration : EntityTypeConfiguration<Author>
    {
        public AuthorConfiguration()
        {
            Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
