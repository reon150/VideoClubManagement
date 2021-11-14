using System.Data.Entity.ModelConfiguration;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Data.Config
{
    public class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            Property(c => c.FirstName).IsRequired().HasMaxLength(100);

            Property(c => c.LastName).IsRequired().HasMaxLength(100);

            Property(c => c.TaxpayerIdentificationNumber).IsRequired().HasMaxLength(11).IsFixedLength();
            HasIndex(c => c.TaxpayerIdentificationNumber).IsUnique();

            Property(c => c.CreditCardNumber).IsRequired().HasMaxLength(16).IsFixedLength();
            HasIndex(c => c.CreditCardNumber).IsUnique();

            Property(c => c.CreditLimit).IsRequired().HasPrecision(10, 4);
        }
    }
}
