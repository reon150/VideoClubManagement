using System;
using System.Collections.Generic;

namespace VideoClubManagement.Data.Entities
{ 
	public class ShiftWork : BaseEntity<int>
	{
		public string Description { get; set; }
		public TimeSpan StartHour { get; set; }
		public TimeSpan FinishHour { get; set; }
		public List<Employee> Employees { get; set; }
	}
}
