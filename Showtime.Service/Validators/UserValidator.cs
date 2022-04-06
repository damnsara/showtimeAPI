using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Showtime.Domain.Entities;
using Showtime.Service.Validators;
using Showtime.Shared;

namespace Showtime.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Username).NotEmpty().WithMessage(String.Format(Messages.FieldNotEmpty, "username"))
                    .NotNull().WithMessage(String.Format(Messages.FieldNotNull, "name"));
            RuleFor(u => u.Email).NotEmpty().WithMessage(String.Format(Messages.FieldNotEmpty, "e-mail"))
                    .NotNull().WithMessage(String.Format(Messages.FieldNotNull, "e-mail"));
            RuleFor(u => u.Password).NotEmpty().WithMessage(String.Format(Messages.FieldNotEmpty, "password"))
                    .NotNull().WithMessage(String.Format(Messages.FieldNotNull, "password"))
                    .MinimumLength(8).WithMessage(String.Format(Messages.MoreThan8, "password"));
            RuleFor(u => u.Role).NotEmpty().WithMessage(String.Format(Messages.FieldNotEmpty, "role"))
                    .NotNull().WithMessage(String.Format(Messages.FieldNotNull, "role"));
        }
    }
}
