using CashFlow.Communication.Enums;
using CashFlow.Communication.Request;
using CashFlow.Communication.Response;
using CashFlow.Exception.ExceptionsBase;
using FluentValidation;
namespace CashFlow.Application.UseCases.Expense.Register;

public class RegisterExpenseUseCase
{
    public ResponseRegisterExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        validate(request);

        return new ResponseRegisterExpenseJson();
    }

  
    

    public void validate(RequestRegisterExpenseJson request) 
    {
        var validator = new RegisterExpenseValidator();
        var result = validator.Validate(request);


        if (result.IsValid == false)
        {
        var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();
            throw new ErrorOnValidationException(errorMessages);
        }
    }

}
