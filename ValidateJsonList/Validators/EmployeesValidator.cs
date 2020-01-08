namespace ValidateJsonList.Validators
{
    using FluentValidation;
    using ValidateJsonList.Models;

    public class EmployeesValidator : AbstractValidator<Employees>
    {
        public EmployeesValidator()
        {
            RuleForEach(x => x.Employee).SetValidator(new EmployeeValidator());
        }
    }
}
