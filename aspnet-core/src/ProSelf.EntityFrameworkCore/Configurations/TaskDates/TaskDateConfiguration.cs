using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProSelf.TaskDates
{
    public class TaskDateConfiguration : IEntityTypeConfiguration<TaskDate>
    {
        public void Configure(EntityTypeBuilder<TaskDate> builder)
        {
            builder.ToTable(ProSelfConsts.DbTablePrefix + "TaskDates");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsRequired();
        }
    }
}
