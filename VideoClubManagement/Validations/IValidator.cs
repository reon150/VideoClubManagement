using System.Collections.Generic;

namespace VideoClubManagement.Validations
{
    public interface IValidator<T> where T : class
    {
        List<string> GetValidationErrors(T entity);
    }
}
