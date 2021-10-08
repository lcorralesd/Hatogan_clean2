using FluentValidation;
using Hatogan.AB.UseCases.DTOs.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.Common.Validator.Animals
{
    public class CreateAnimalValidator : AbstractValidator<CreateAnimalDTO>
    {
        public CreateAnimalValidator()
        {
            RuleFor(a => a.Code)
                .NotEmpty().WithMessage("Debe ingresar un valor para el campo Código")
                .MaximumLength(15).WithMessage("El campo Código no debe tener más de 15 caracteres");
            RuleFor(a => a.EarTag)
                .MaximumLength(15).WithMessage("El campo Etiqueta de oreja no debe tener más de 15 caracteres");
            RuleFor(a => a.Name)
                .MaximumLength(20).WithMessage("El campo Nombre no debe tener más de 20 caracteres");
            RuleFor(a => a.Color)
                .MaximumLength(20).WithMessage("El campo Color no debe tener más de 20 caracteres");
            RuleFor(a => a.BirthWeight)
                .GreaterThan(25.0).WithMessage("El peso de nacimiento debe ser mayor de 25 kilos")
                .LessThan(1200.00).WithMessage("El peso no debe ser mayor de 1000 kilos");
            RuleFor(a => a.IncomeWeight)
                .GreaterThan(25.0).WithMessage("El peso de nacimiento debe ser mayor de 25 kilos")
                .LessThan(1200.00).WithMessage("El peso no debe ser mayor de 1000 kilos");

        }
    }
}
