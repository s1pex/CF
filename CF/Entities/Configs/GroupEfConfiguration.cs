using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CF.Entities.Configs
{
    public class GroupEfConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(e => e.Id).HasName("Group_pk");
            builder.Property(e => e.Id).UseIdentityColumn();

            builder.Property(e => e.Name).IsRequired().HasMaxLength(30);

            builder.ToTable("Group");

            Group[] groups =
            {
                new Group{ Id = 1, Name = "14c"},
                new Group{ Id = 2,Name = "16c"},
            };
            builder.HasData(groups);
        }
    }
}
