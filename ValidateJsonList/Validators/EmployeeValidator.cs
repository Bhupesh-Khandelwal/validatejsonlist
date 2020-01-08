namespace ValidateJsonList.Validators
{
    using FluentValidation;
    using ValidateJsonList.Models;

    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required!");
            RuleFor(x => x.EmailId).NotEmpty().WithMessage("Email is required!");
            RuleFor(x => x.EmailId).EmailAddress().WithMessage("Enter a valid Email Address");
        }
    }
}
