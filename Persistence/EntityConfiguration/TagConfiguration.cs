using System.Data.Entity.ModelConfiguration;

namespace RepositoryPattern.Persistence.EntityConfiguration
{
    class TagConfiguration : EntityTypeConfiguration<Tag>
    {
        public TagConfiguration()
        {
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
