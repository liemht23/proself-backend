using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProSelf.Tasks
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.ToTable(ProSelfConsts.DbTablePrefix + "Tasks");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired();
            builder.Property(x => x.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsRequired();
        }
    }
}
