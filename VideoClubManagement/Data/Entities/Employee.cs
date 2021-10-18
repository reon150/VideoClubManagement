using System;
using System.Collections.Generic;

namespace VideoClubManagement.Data.Entities
{
	public class Employee : BaseEntity<int>
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string IdentificationNumber { get; set; }	
		public decimal CommissionPercentage { get; set; }
		public DateTime EnteringDate { get; set; }

		public int ShiftWorkId { get; set; }
		public ShiftWork ShiftWork { get; set; }

        public List<ArticleLending> ArticleLendings { get; set; }
    }
}
