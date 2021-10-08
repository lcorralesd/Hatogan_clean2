using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.Common.Validator
{
    public static class Validator<Model>
    {
        public static Task<List<ValidationFailure>> Validate(Model model, IEnumerable<IValidator<Model>> validators, bool causesException = true)
        {
            var failures = validators
                .Select(v => v.Validate(model))
                .SelectMany(r => r.Errors)
                .Where(vf => vf != null)
                .ToList();

            return failures.Any() && causesException ? throw new ValidationException(failures) : Task.FromResult(failures);
        }

    }
}
