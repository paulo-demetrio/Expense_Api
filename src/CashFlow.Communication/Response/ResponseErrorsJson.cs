using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CashFlow.Communication.Response;

public class ResponseErrorJson
{
    public List<string> ErrorMessages { get; set; }

    public ResponseErrorJson(string errorMessage)
    {
        ErrorMessages = new List<string> { errorMessage};
    }



    public ResponseErrorJson(List<string> errorMessage)
    {
        ErrorMessages = errorMessage;
    }

}
