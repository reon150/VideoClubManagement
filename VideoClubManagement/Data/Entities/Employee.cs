using System;
namespace VideoClubManagement.Data.Entities
{
	public class Employee : BaseEntity<int>
	{
		public string Name { get; set; }
		public string IdentificationNumber { get; set; }
		public ShiftWork ShiftWork { get; set; }
		public decimal ComisionPercentage { get; set; }
		public DateTime EnteringDate { get; set; }
	}
}
