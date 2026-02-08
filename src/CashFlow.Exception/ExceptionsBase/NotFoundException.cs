using System.Net;

namespace CashFlow.Exception.ExceptionsBase;

public class NotFoundException : CashFlowException
{
    public NotFoundException(string message) : base(message)
    {
    }

    public override int Statuscode => (int)HttpStatusCode.NotFound;

    public override List<string> GetErrors() => [Message];
}
