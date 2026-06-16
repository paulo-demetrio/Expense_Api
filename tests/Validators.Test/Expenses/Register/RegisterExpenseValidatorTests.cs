using CashFlow.Application.UseCases.Expense.Register;
using CommonTestUtilities.Request;
using FluentAssertions;

namespace Validators.Test.Expenses.Register;

public class RegisterExpenseValidatorTests
{
    [Fact]
    public void successfully_validate_register_expense()
    {
        var validator = new RegisterExpenseValidator();
        var request = RequestRegisterExpenseJsonBuilder.Build();


        var result = validator.Validate(request);


        result.IsValid.Should().BeTrue();

    }








}
