namespace CabInvoiceGenerator;

public class InvoiceException : Exception
{
    private readonly ExceptionType errorType;

    public enum ExceptionType
    {
        NULL_RIDES
    }

    public ExceptionType ErrorType { get { return errorType; } }

    public InvoiceException(ExceptionType type, string message) : base(message)
    {
        errorType = type;
    }
}