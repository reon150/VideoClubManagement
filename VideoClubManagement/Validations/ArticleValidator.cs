using System.Collections.Generic;
using System.Data.Entity;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Validations
{
    public class ArticleValidator : IValidator<Article>
    {
        private readonly IDbSet<Article> _dbContext;

        public ArticleValidator(IDbSet<Article> dbContext) => _dbContext = dbContext;

        public List<string> GetValidationErrors(Article entity)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(entity.Title))
                errors.Add("El título no puede estar vacio.");
            else if (entity.Title.Length > 100)
                errors.Add("La longitud del nombre no puede ser mayor a 100.");

            if (entity.RentPerDay <= 0)
                errors.Add("El monto por día no puede ser 0.");

            if (entity.RentalDays <= 0)
                errors.Add("Los días de renta no pueden ser 0");

            if (entity.LateReturnFee <= 0)
                errors.Add("La penalidad por retorno tardio no puede ser 0");

            return errors;
        }
    }
}