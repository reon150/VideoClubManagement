using System;

namespace VideoClubManagement.Data.Entities
{
    public interface ITrackable
    {
        DateTime CreatedDate { get; set; }
        DateTime LastUpdatedDate { get; set; }
    }
}
