using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VideoClubManagement.Data.Entities;
using VideoClubManagement.Helpers;

namespace VideoClubManagement.Validations
{
    public class UserValidator : IValidator<User>
    {
        private readonly IDbSet<User> _dbContext;

        public UserValidator(IDbSet<User> dbContext) => _dbContext = dbContext;

        public List<string> GetValidationErrors(User entity)
        {
            List<string> errors = new List<string>(); 

            if (string.IsNullOrWhiteSpace(entity.IdentificationNumber))
            {
                errors.Add("La cédula no puede estar vacio.");
            }
            else if (entity.IdentificationNumber.Length != 11)
            {
                errors.Add("La longitud de la cédula debe ser de 11 digitos.");
            }
            else if (!long.TryParse(entity.IdentificationNumber, out long result))
            {
                errors.Add("La cédula solo puede contener digitos númericos");
            }
            else if (!ValidatorHelper.IsAValidIdentityDocument(entity.IdentificationNumber))
            {
                errors.Add("La cédula no es valida.");
            }
            else if (entity.Id > 0)
            {
                if (!_dbContext.FirstOrDefault(x => x.Id == entity.Id).IdentificationNumber.Equals(entity.IdentificationNumber)
                    && _dbContext.FirstOrDefault(x => x.IdentificationNumber == entity.IdentificationNumber) != null)
                    errors.Add("La cédula ya se encuentra registrada en el sistema.");
            }
            else
            {
                if (_dbContext.FirstOrDefault(x => x.IdentificationNumber == entity.IdentificationNumber) != null)
                    errors.Add("La cédula ya se encuentra registrada en el sistema.");
            }


            if (string.IsNullOrWhiteSpace(entity.UserName))
            {
                errors.Add("El nombre de usuario no puede estar vacio.");
            }
            else if (entity.UserName.Length > 20)
            {
                errors.Add("La longitud del nombre de usuario no debe ser de mayor a 20 dígitos.");
            }
            else if (entity.Id > 0)
            {
                if (!_dbContext.FirstOrDefault(x => x.Id == entity.Id).UserName.Equals(entity.UserName)
                    && _dbContext.FirstOrDefault(x => x.UserName == entity.UserName) != null)
                    errors.Add("El nombre de usuario ya se encuentra registrado en el sistema.");
            }
            else
            {
                if (_dbContext.FirstOrDefault(x => x.UserName == entity.UserName) != null)
                    errors.Add("El nombre de usuario ya se encuentra registrado en el sistema.");
            }

            if (string.IsNullOrWhiteSpace(entity.Email))
            {
                errors.Add("El correo electrónico no puede estar vacio.");
            }  
            else if (entity.Email.Length > 20)
            {
                errors.Add("La longitud del correo electrónico no debe ser de mayor a 20 dígitos.");
            }
            else if (!ValidatorHelper.IsValidEmail(entity.Email))
            {
                errors.Add("El correo electrónico digitado no es valido.");
            }
            else if (entity.Id > 0)
            {
                if (!_dbContext.FirstOrDefault(x => x.Id == entity.Id).Email.Equals(entity.Email)
                    && _dbContext.FirstOrDefault(x => x.Email == entity.Email) != null)
                    errors.Add("El correo electrónico ya se encuentra registrado en el sistema.");
            }
            else
            {
                if (_dbContext.FirstOrDefault(x => x.Email == entity.Email) != null)
                    errors.Add("El correo electrónico ya se encuentra registrado en el sistema.");
            }
                    
            if (string.IsNullOrWhiteSpace(entity.Password))
                errors.Add("La contraseña no puede estar vacio.");
            else if (entity.Password.Length > 50)
                errors.Add("La longitud de la contraseña no debe ser de mayor a 50 dígitos.");

            return errors;
        }
    }
}
