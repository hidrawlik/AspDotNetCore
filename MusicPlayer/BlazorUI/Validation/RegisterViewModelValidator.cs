﻿using BlazorUI.Models.AccountModels;
using FluentValidation;

namespace BlazorUI.Validation
{
    public class RegisterViewModelValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidator()
        {
            RuleFor(e => e.userName)
                .NotEmpty()
                .MinimumLength(2).WithMessage("Мінімум 2 символи")
                .MaximumLength(20).WithMessage("Максимум 20 символів");

            RuleFor(e => e.email)
                .NotNull()
                .EmailAddress();

            RuleFor(e => e.password)
                .NotNull()
                .MinimumLength(4).WithMessage("Довжина паролю мінімум 4 символи");

            RuleFor(e => e.confirmPassword)
                .Equal(e => e.password).WithMessage("Паролі не збігаються");
        }
    }
}
