﻿using CarWorkshop.Domain.Interfaces;
using FluentValidation;

namespace CarWorkshop.Application.CarWorkshop.Commands.CreateCarWorkshop;

public class CreateCarWorkshopCommandValidator : AbstractValidator<CreateCarWorkshopCommand>
{
    public CreateCarWorkshopCommandValidator(ICarWorkshopRepository repository)
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Please enter name")
            .MinimumLength(2).WithMessage("Name should have atleast 2 characters")
            .MaximumLength(20).WithMessage("Name should have maximum 20 characters")
            .Custom((value, context) =>
            {
                var existingCarWorkshop = repository.GetByName(value).Result;

                if (existingCarWorkshop is not null)
                {
                    context.AddFailure($"{value} is not unique name for car workshop");
                }
            });

        RuleFor(c => c.Description)
            .NotEmpty().WithMessage("Please enter description");

        RuleFor(c => c.PhoneNumber)
            .MinimumLength(8).WithMessage("Phone number should have atleast 2 characters")
            .MaximumLength(12).WithMessage("Phone number should have maximum 12 characters"); ;
    }
}