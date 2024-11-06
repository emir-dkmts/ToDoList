using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDo.Models.Entities;

namespace ToDo.DataAccess.Configurations;

public class CategoryConfigurations : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Category").HasKey(c => c.Id);
        builder.Property(c => c.Id).HasColumnName("Id");
        builder.Property(c => c.CreatedDate).HasColumnName("CreatedTime");
        builder.Property(c => c.UpdatedDate).HasColumnName("UpdatedTime");
        builder.Property(c => c.Name).HasColumnName("CategoryName");

        builder
            .HasMany(c => c.ToDos)
            .WithOne(c => c.Category)
            .HasForeignKey(c => c.CategoryId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasData(new Category
        {
            Id = 1,
            Name = "Daily Work",
            CreatedDate = DateTime.Now
        });
    }
}
