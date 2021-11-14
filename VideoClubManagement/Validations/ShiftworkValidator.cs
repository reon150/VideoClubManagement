using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Validations
{
    class ShiftworkValidator : IValidator<ShiftWork>
    {
        private readonly IDbSet<ShiftWork> _dbContext;
        public ShiftworkValidator(IDbSet<ShiftWork> dbContext) => _dbContext = dbContext;

        public List<string> GetValidationErrors(ShiftWork entity)
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrWhiteSpace(entity.Description))
                errors.Add("El nombre no puede estar vacio.");
            else if (entity.Description.Length > 100)
                errors.Add("La longitud del nombre no puede ser mayor a 100.");
          
            return errors;

        }

        public object GetValidationErrors(object cast)
        {
            throw new NotImplementedException();
        }
    }
}
