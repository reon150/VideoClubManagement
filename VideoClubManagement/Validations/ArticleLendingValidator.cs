using System;
using System.Collections.Generic;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Validations
{
    public class ArticleLendingValidator : IValidator<ArticleLending>
    {
        public List<string> GetValidationErrors(ArticleLending entity)
        {
            List<string> errors = new List<string>();

            if (entity.AmountPerDay < 0)
                errors.Add("El monto por dia no puede ser menor a 0.");

            if (entity.DueDate < DateTime.Now.Date)
                errors.Add("La fecha de devolución no puede ser menor a la fecha actual.");

            if (entity.Comment.Length > 1000)
                errors.Add("La longitud del comentario no puede ser mayor a 1000.");

            return errors;
        }
    }
}
