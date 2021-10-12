﻿using System;
namespace VideoClubManagement.Data.Entities
{
	public class Employee : BaseEntity<int>
	{
		public string FisrtName { get; set; }
		public string LastName { get; set; }
		public string IdentificationNumber { get; set; }	
		public decimal CommissionPercentage { get; set; }
		public DateTime EnteringDate { get; set; }

		public int ShiftWorkId { get; set; }
		public ShiftWork ShiftWork { get; set; }
	}
}
