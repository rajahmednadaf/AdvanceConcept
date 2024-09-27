namespace AdvanceConsept.CutomException
{
    public class CustomErrorException : Exception
    {
        public int ErrorCode { get; private set; }

        public CustomErrorException(int errorCode, string errorMessage) : base(errorMessage) 
        {
            ErrorCode = errorCode;
        }


        public CustomErrorException(int errorCode, string errorMessage, Exception inner) : base(errorMessage,inner)
        {
            ErrorCode = errorCode;
        }

        public override string ToString()
        {
            return $"Error Code: {ErrorCode}, Message: {Message}\n{StackTrace}";
        }
    }
}
