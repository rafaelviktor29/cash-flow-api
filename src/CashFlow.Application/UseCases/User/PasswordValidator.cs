using CashFlow.Exception;
using FluentValidation;
using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace CashFlow.Application.UseCases.User;

public partial class PasswordValidator<T> : PropertyValidator<T, string>
{
    private const string ERROR_MESSAGE_KEY = "ErrorMessage";

    public override string Name => "PasswordValidator";

    protected override string GetDefaultMessageTemplate(string errorCode)
    {
        return $"{{{ERROR_MESSAGE_KEY}}}";
    }

    public override bool IsValid(ValidationContext<T> context, string password)
    {
        if (string.IsNullOrWhiteSpace(password) || !Passwordpolicy().IsMatch(password))
        {
            context.MessageFormatter.AppendArgument(ERROR_MESSAGE_KEY, ResourceErrorMessages.INVALID_PASSWORD);
            return false;
        }

        return true;
    }

    [GeneratedRegex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")]
    private static partial Regex Passwordpolicy();
}
