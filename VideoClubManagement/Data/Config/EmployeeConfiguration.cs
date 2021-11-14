using System.Data.Entity.ModelConfiguration;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Data.Config
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            Property(e => e.FirstName).IsRequired().HasMaxLength(100);

            Property(e => e.LastName).IsRequired().HasMaxLength(100);

            Property(e => e.IdentificationNumber).IsRequired().HasMaxLength(11).IsFixedLength();
            HasIndex(e => e.IdentificationNumber).IsUnique();

            Property(e => e.CommissionPercentage).IsRequired().HasPrecision(10, 4);

            Property(e => e.EnteringDate).HasColumnType("date"); 
        }
    }
}
