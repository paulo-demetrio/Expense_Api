using Bogus;
using CashFlow.Communication.Enums;
using CashFlow.Communication.Request;

namespace CommonTestUtilities.Request;

public  class RequestRegisterExpenseJsonBuilder
{



    public static RequestRegisterExpenseJson Build()
    {
        return new Faker<RequestRegisterExpenseJson>()
            .RuleFor(r => r.Title, Faker => Faker.Commerce.ProductName())
            .RuleFor(r=> r.Date, faker => faker.Date.Past())
            .RuleFor(r => r.Amount, faker => faker.Random.Decimal(1,1000))
            .RuleFor(r => r.Description, faker =>faker.Commerce.Product())
            .RuleFor(r => r.PaymentType, faker => faker.PickRandom<PaymentType>());

    }


}
