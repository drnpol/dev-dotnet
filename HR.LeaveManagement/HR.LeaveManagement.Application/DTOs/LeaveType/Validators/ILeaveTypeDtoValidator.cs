using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace HR.LeaveManagement.Application.DTOs.LeaveType.Validators
{
    class ILeaveTypeDtoValidator : AbstractValidator<ILeaveTypeDto>
    {
        public ILeaveTypeDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} must not be empty")
                .NotNull().WithMessage("{PropertyName} must not be null")
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed {MaxLength} characters");
            RuleFor(x => x.DefaultDays)
                .NotEmpty().WithMessage("{PropertyName} must not be empty")
                .NotNull().WithMessage("{PropertyName} must not be null")
                .GreaterThan(0).WithMessage("{PropertyName} must be greater than {ComparisonValue}");
        }
    }
}
