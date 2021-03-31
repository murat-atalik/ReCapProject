﻿using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u=>u.Firstname).NotNull();
            RuleFor(u => u.Firstname).MinimumLength(2);
            RuleFor(u => u.LastName).NotNull();
            RuleFor(u => u.LastName).MinimumLength(2);
            RuleFor(u=>u.EmailAddress).NotNull();
        }
    }
}
