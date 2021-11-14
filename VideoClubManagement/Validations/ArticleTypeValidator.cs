using System.Collections.Generic;
using System.Data.Entity;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Validations
{
    public class ArticleTypeValidator : IValidator<ArticleType>
    {
        private readonly IDbSet<ArticleType> _dbContext;

        public ArticleTypeValidator(IDbSet<ArticleType> dbContext) => _dbContext = dbContext;

        public List<string> GetValidationErrors(ArticleType entity)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(entity.Name))
                errors.Add("El nombre no puede estar vacio.");
            else if (entity.Name.Length > 100)
                errors.Add("La longitud del nombre no puede ser mayor a 100.");

            if (string.IsNullOrWhiteSpace(entity.Description))
                errors.Add("La descripció no puede estar vacía.");
            else if (entity.Description.Length > 100)
                errors.Add("La longitud de la descripción no puede ser mayor a 100.");

            return errors;
        }
    }
}
