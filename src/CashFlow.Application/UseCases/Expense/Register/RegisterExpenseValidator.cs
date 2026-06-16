using CashFlow.Communication.Request;
using CashFlow.Exception;
using FluentValidation;

namespace CashFlow.Application.UseCases.Expense.Register;

public class RegisterExpenseValidator : AbstractValidator<RequestRegisterExpenseJson>
{
    public RegisterExpenseValidator() 
    {
        RuleFor(req => req.Title).NotEmpty().WithMessage(ResourceErrorMessages.TitleError);
        RuleFor(req => req.Amount).GreaterThan(0).WithMessage(ResourceErrorMessages.AmountError);
        RuleFor(req => req.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage(ResourceErrorMessages.DateError);
        RuleFor(req => req.PaymentType).IsInEnum().WithMessage(ResourceErrorMessages.PaymentTypeError);



    }

}
