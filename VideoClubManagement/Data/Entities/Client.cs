    namespace VideoClubManagement.Data.Entities
{
    public class Client : BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TaxpayerIdentificationNumber { get; set; }
        public string CreditCardNumber { get; set; }
        public decimal CreditLimit { get; set; }
    }
}
