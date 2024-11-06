using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDo.Models.Entities;

namespace ToDo.DataAccess.Configurations;

public class ToDoConfigurations : IEntityTypeConfiguration<ToDo.Models.Entities.ToDo>
{
    public void Configure(EntityTypeBuilder<Models.Entities.ToDo> builder)
    {
        builder.ToTable("ToDos").HasKey(t => t.Id);
        builder.Property(t => t.Id).HasColumnName("ToDoId");
        builder.Property(t => t.StartDate).HasColumnName("ToDoStartDate");
        builder.Property(x => x.CreatedDate).HasColumnName("CreatedTime");
        builder.Property(x => x.UpdatedDate).HasColumnName("UpdatedTime");
        builder.Property(t => t.Completed).HasColumnName("ToDoCompleted");
        builder.Property(x => x.Title).HasColumnName("Title");
        builder.Property(x => x.Description).HasColumnName("Description");
        builder.Property(x => x.UserId).HasColumnName("UserId");
        builder.Property(x => x.CategoryId).HasColumnName("CategoryId");
        builder.Property(t => t.Priority)
            .HasColumnName("Priority")
            .HasConversion<string>();

        builder.HasOne(x => x.User)
            .WithMany(x => x.ToDos)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Category)
            .WithMany(x => x.ToDos)
            .HasForeignKey(x => x.CategoryId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Navigation(x => x.User).AutoInclude();
        builder.Navigation(x => x.Category).AutoInclude();
    }
}
