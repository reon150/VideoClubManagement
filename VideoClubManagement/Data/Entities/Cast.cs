namespace VideoClubManagement.Data.Entities 
{

	public class Cast : BaseEntity<int>
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}
