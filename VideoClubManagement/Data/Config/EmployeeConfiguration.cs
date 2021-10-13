using System.Data.Entity.ModelConfiguration;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Data.Config
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            Property(e => e.FisrtName).IsRequired().HasMaxLength(100);

            Property(e => e.LastName).IsRequired().HasMaxLength(100);

            Property(e => e.IdentificationNumber).IsRequired().HasMaxLength(11).IsFixedLength();

            Property(e => e.CommissionPercentage).IsRequired().HasPrecision(10, 4);

            Property(e => e.EnteringDate).HasColumnType("date");
        }
    }
}
