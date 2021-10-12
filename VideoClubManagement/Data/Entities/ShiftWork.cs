using System;

namespace VideoClubManagement.Data.Entities
{ 
	public class ShiftWork : BaseEntity<int>
	{
		public string Description { get; set; }
		public TimeSpan StartHour { get; set; }
		public string FinishHour { get; set; }
	}
}
