using FluentValidation;

namespace CarWorkshop.Application.CarWorkshop.Commands.EditCarWorkshop;

public class EditCarWorkshopCommandValidator : AbstractValidator<EditCarWorkshopCommand>
{
    public EditCarWorkshopCommandValidator()
    {
        RuleFor(c => c.Description)
            .NotEmpty().WithMessage("Please enter description");

        RuleFor(c => c.PhoneNumber)
            .MinimumLength(8).WithMessage("Phone number should have atleast 2 characters")
            .MaximumLength(12).WithMessage("Phone number should have maximum 12 characters");
    }
}