using System;

namespace VideoClubManagement.Data.Entities
{ 
	public class ShiftWork : BaseEntity<int>
	{
		public string Description { get; set; }
		public TimeSpan StartHour { get; set; }
		public TimeSpan FinishHour { get; set; }
	}
}
