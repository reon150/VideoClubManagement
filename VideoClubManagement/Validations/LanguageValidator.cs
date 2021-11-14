using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Validations
{
    class LanguageValidator : IValidator<Language>
    {
        private readonly IDbSet<Language> _dbContext;
        public LanguageValidator(IDbSet<Language> dbContext) => _dbContext = dbContext;
        public List<string> GetValidationErrors(Language entity)
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrWhiteSpace(entity.Description))
                errors.Add("El nombre no puede estar vacio.");
            else if (entity.Description.Length > 100)
                errors.Add("La longitud del nombre no puede ser mayor a 100.");
            if (string.IsNullOrWhiteSpace(entity.ISOCode))
                errors.Add("El nombre no puede estar vacio.");
            else if (entity.ISOCode.Length > 3)
                errors.Add("La longitud del codigo de idioma no puede ser mayor a 3.");
            if (!string.IsNullOrWhiteSpace(entity.ISOCode) && entity.Id > 0)
            {
                if (!_dbContext.FirstOrDefault(x => x.Id == entity.Id).ISOCode.Equals(entity.ISOCode)
                    && _dbContext.FirstOrDefault(x => x.ISOCode == entity.ISOCode) != null)
                    errors.Add("El codigo de idioma ya se encuentra registrado en el sistema.");
            }
            else if (!string.IsNullOrWhiteSpace(entity.ISOCode))
            {
                if (_dbContext.FirstOrDefault(x => x.ISOCode == entity.ISOCode) != null)
                    errors.Add("El codigo de idioma ya se encuentra registrado en el sistema.");
            }
            return errors;
        }
        public object GetValidationErrors(object cast)
        {
            throw new NotImplementedException();
        }
    }
}
