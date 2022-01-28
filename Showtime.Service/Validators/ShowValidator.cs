using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Showtime.Domain.Entities;
using Showtime.Shared;

namespace Showtime.Service.Validators
{
    public class ShowValidator : AbstractValidator<Show>
    {
        public ShowValidator()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage(String.Format(Messages.FieldNotEmpty,"name"))
                                .NotNull().WithMessage(String.Format(Messages.FieldNotNull, "name"));
            RuleFor(s => s.NumberOfSeasons).NotEmpty().WithMessage(String.Format(Messages.FieldNotEmpty, "number of seasons"))
                                           .NotNull().WithMessage(String.Format(Messages.FieldNotNull, "number of seasons"));
            RuleFor(s => s.Channel).NotEmpty().WithMessage(String.Format(Messages.FieldNotEmpty, "channel"))
                                   .NotNull().WithMessage(String.Format(Messages.FieldNotNull, "channel"));
            RuleFor(s => s.ParentalRating).NotEmpty().WithMessage(String.Format(Messages.FieldNotEmpty, "parental rating"))
                                          .NotNull().WithMessage(String.Format(Messages.FieldNotNull, "parental rating"))
                                          .ExclusiveBetween(10, 18)
                                            .NotEqual(11).WithMessage(String.Format(Messages.ParentalRatingRestriction))
                                            .NotEqual(13).WithMessage(String.Format(Messages.ParentalRatingRestriction))
                                            .NotEqual(15).WithMessage(String.Format(Messages.ParentalRatingRestriction))
                                            .NotEqual(17).WithMessage(String.Format(Messages.ParentalRatingRestriction));
        }

    }

}
