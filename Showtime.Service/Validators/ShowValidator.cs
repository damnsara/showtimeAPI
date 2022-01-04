using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Showtime.Domain.Entities;



namespace Showtime.Service.Validators
{
    public class ShowValidator : AbstractValidator<Show>
    {
        public ShowValidator()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage("This field cannot be empty. Please enter the name")
                                .NotNull().WithMessage("This field cannot be empty. Please enter the name");
            RuleFor(s => s.NumberOfSeasons).NotEmpty().WithMessage("This field cannot be empty. Please enter the number of seasons")
                                           .NotNull().WithMessage("This field cannot be empty. Please enter the number of seasons");
            RuleFor(s => s.Channel).NotEmpty().WithMessage("This field cannot be empty. Please enter the channel")
                                   .NotNull().WithMessage("This field cannot be empty. Please enter the channel");
            RuleFor(s => s.ParentalRating).NotEmpty().WithMessage("This field cannot be empty. Please enter the parental rating")
                                          .NotNull().WithMessage("This field cannot be empty. Please enter the parental rating")
                                          .ExclusiveBetween(10, 18)
                                            .NotEqual(11).WithMessage("Only pair numbers accepted")
                                            .NotEqual(13).WithMessage("Only pair numbers accepted")
                                            .NotEqual(15).WithMessage("Only pair numbers accepted")
                                            .NotEqual(17).WithMessage("Only pair numbers accepted");
        }

    }

}
