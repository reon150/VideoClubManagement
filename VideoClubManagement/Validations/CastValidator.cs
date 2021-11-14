using System;
using System.Collections.Generic;
using System.Data.Entity;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Validations
{
    public class CastValidator : IValidator<Cast>
    {
        private readonly IDbSet<Cast> _dbContext;
        public CastValidator(IDbSet<Cast> dbContext) => _dbContext = dbContext;
       public List<string> GetValidationErrors(Cast entity)
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrWhiteSpace(entity.FirstName))
                errors.Add("El nombre no puede estar vacio.");
            else if (entity.FirstName.Length > 100)
                errors.Add("La longitud del nombre no puede ser mayor a 100.");
            if (string.IsNullOrWhiteSpace(entity.LastName))
                errors.Add("El apellido no puede estar vacio.");
            else if (entity.LastName.Length > 100)
                errors.Add("La longitud del apellido no puede ser mayor a 100.");
            return errors;
        }
        public object GetValidationErrors(object cast)
        {
            throw new NotImplementedException();
        }
    }
}
