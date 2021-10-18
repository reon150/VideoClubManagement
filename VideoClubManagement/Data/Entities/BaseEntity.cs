using System;
namespace VideoClubManagement.Data.Entities
{
    public abstract class BaseEntity<T> : ITrackable
    {
        public T Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
