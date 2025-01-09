using ApiProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiProject.DAL.Configurations;

public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
{
    public void Configure(EntityTypeBuilder<Assignment> builder)
    {
        builder.Property(x => x.Title)
            .HasMaxLength(32);

        builder.Property(x => x.Descryption)
            .HasMaxLength(64);

        builder.HasOne(x => x.Topic)
            .WithMany(x => x.Assignments)
            .HasForeignKey(x => x.TopicId);

        builder.HasOne(x => x.Employee)
            .WithMany(x => x.Assignments)
            .HasForeignKey(x => x.EmployeeId);

        builder.HasMany(x => x.Tags)
            .WithMany(x => x.Assignments);
    }
}
