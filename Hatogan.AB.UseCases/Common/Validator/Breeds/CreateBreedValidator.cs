using FluentValidation;
using Hatogan.AB.UseCases.DTOs.Breeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.Common.Validator.Breeds
{
    public class CreateBreedValidator : AbstractValidator<CreateBreedDTO>
    {
        public CreateBreedValidator()
        {
            RuleFor(b => b.Name)
                .NotEmpty().WithMessage("Debe ingresar un valor para el campo Nombre")
                .MaximumLength(20).WithMessage("El campo Nombre no debe tener más de 20 caracteres");
        }
    }
}
