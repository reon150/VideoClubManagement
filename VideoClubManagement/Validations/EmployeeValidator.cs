using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubManagement.Data.Entities;
using VideoClubManagement.Helpers;

namespace VideoClubManagement.Validations
{
    class EmployeeValidator : IValidator<Employee>
    {
        private readonly IDbSet<Employee> _dbContext;

        public EmployeeValidator(IDbSet<Employee> dbContext) => _dbContext = dbContext;

        public List<string> GetValidationErrors(Employee entity)
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
            if (string.IsNullOrWhiteSpace(entity.IdentificationNumber))
                errors.Add("La cedula no puede estar vacia.");
            else if (!long.TryParse(entity.IdentificationNumber, out long result))
                errors.Add("La cedula solo puede contener digitos númericos");
            else if (!ValidatorHelper.IsAValidIdentityDocument(entity.IdentificationNumber.PadLeft(11, '0'))
                && !ValidatorHelper.IsAValidJuridicTaxpayerIdentificationNumber(entity.IdentificationNumber.PadLeft(9, '0')))
                errors.Add("La cedula no es valida.");
            if (!string.IsNullOrWhiteSpace(entity.IdentificationNumber))
            {
                if (_dbContext.FirstOrDefault(x => x.IdentificationNumber == entity.IdentificationNumber) != null)
                    errors.Add("La cedula ya se encuentra registrado en el sistema.");
            }

            



            return errors;
        }

        public object GetValidationErrors(object cast)
        {
            throw new NotImplementedException();
        }
    }
}
