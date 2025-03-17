using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyAPI.DAL;

internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.Property("Name").HasMaxLength(100).IsRequired();
        builder.Property("Salary").HasColumnType("decimal(18,2)").HasDefaultValue(0);
        builder.Property("Address").HasMaxLength(100);
    }
}
