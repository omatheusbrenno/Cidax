namespace Cidax.Exceptions.ExceptionsBase
{
    public class ErrorOnValidationException : CidaxException
    {
        public IList<string> ErrorsMessages { get; set; }
        public ErrorOnValidationException(IList<string> errosMessages)
        {
            ErrorsMessages = errosMessages;
        }
    }
}
