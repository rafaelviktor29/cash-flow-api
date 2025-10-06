namespace CashFlow.Communication.Responses;

public class ResponseErrorJson
{
    public List<String> ErrorMessages { get; set; }

    public ResponseErrorJson(string errorMessage)
    {
        ErrorMessages = [errorMessage];
    }

    public ResponseErrorJson(List<string> errorMessages)
    {
        ErrorMessages = errorMessages;
    }
}
