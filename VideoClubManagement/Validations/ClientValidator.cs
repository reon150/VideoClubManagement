using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VideoClubManagement.Data.Entities;
using VideoClubManagement.Helpers;

namespace VideoClubManagement.Validations
{
    public class ClientValidator : IValidator<Client>
    {
        private readonly IDbSet<Client> _dbContext;

        public ClientValidator(IDbSet<Client> dbContext) => _dbContext = dbContext;

        public List<string> GetValidationErrors(Client entity)
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

            if (string.IsNullOrWhiteSpace(entity.TaxpayerIdentificationNumber))
                errors.Add("La cedula o RNC no puede estar vacio.");
            else if(!long.TryParse(entity.TaxpayerIdentificationNumber, out long result))
                errors.Add("La cedula o el RNC solo puede contener digitos númericos");
            else if (!ValidatorHelper.IsAValidIdentityDocument(entity.TaxpayerIdentificationNumber.PadLeft(11, '0')) 
                && !ValidatorHelper.IsAValidJuridicTaxpayerIdentificationNumber(entity.TaxpayerIdentificationNumber.PadLeft(9, '0')))
                errors.Add("La cedula o el RNC no es valido.");

            if (string.IsNullOrWhiteSpace(entity.CreditCardNumber))
                errors.Add("El No. Tarjeta CR no puede estar vacio.");
            else if (!long.TryParse(entity.CreditCardNumber, out long result))
                errors.Add("El No. Tarjeta CR solo puede contener digitos númericos");

            if (entity.CreditLimit <= 0)
                errors.Add("El límite de credito debe ser mayor a 0");

            if (!string.IsNullOrWhiteSpace(entity.TaxpayerIdentificationNumber))
            {
                if (_dbContext.FirstOrDefault(x => x.TaxpayerIdentificationNumber == entity.TaxpayerIdentificationNumber) != null)
                    errors.Add("La cedula o el RNC ya se encuentra registrado en el sistema.");
            }

            if (!string.IsNullOrWhiteSpace(entity.CreditCardNumber))
            {
                if (_dbContext.FirstOrDefault(x => x.CreditCardNumber == entity.CreditCardNumber) != null)
                    errors.Add("El No. Tarjeta CR ya se encuentra registrado en el sistema.");
            }

            return errors;
        }
    }
}
