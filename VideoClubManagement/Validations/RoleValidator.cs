using System.Collections.Generic;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Validations
{
    public class RoleValidator : IValidator<Role>
    {
        public List<string> GetValidationErrors(Role entity)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(entity.Name))
                errors.Add("El título no puede estar vacio.");
            else if (entity.Name.Length > 50)
                errors.Add("La longitud del nombre no puede ser mayor a 50.");

            if (string.IsNullOrWhiteSpace(entity.Description))
                errors.Add("El título no puede estar vacio.");
            else if (entity.Description.Length > 500)
                errors.Add("La longitud de la descripción no puede ser mayor a 500.");

            return errors;
        }
    }
}
