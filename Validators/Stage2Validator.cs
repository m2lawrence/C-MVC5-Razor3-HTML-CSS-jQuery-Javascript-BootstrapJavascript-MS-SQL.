using WebAppSchedule.Models;
using FluentValidation;

namespace WebAppSchedule.Validators
{
    public class Stage2Validator : AbstractValidator<Stage2>
    {
        public Stage2Validator()
        {
            RuleFor(stage2 => stage2.CustomerID)
           .NotNull()
           .WithMessage("Supply Customer ID");

            //calendar:   
            RuleFor(stage2 => stage2.EventDate)
           .NotNull()
           .WithMessage("Supply Event Date");
            
            RuleFor(stage2 => stage2.Surname)
            .NotNull()
            .WithMessage("Supply Surname");
            
            RuleFor(stage2 => stage2.Address)
           .NotNull()
           .WithMessage("Supply Address");

            RuleFor(stage2 => stage2.Email)
           .NotNull()
           .WithMessage("Supply Email");

            RuleFor(stage2 => stage2.MobileNumber)
           .NotNull()
           .WithMessage("Supply Mobile Number");
        }
    }
}