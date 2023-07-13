namespace WMS.Sisdep.Infra.Middleware
{
    public class CustomException : Exception
    {
        public CustomException(string title, int httpStatusCode, string message) : base(message)
        {
            HttpStatusCode = httpStatusCode;
            Title = title;
        }
        public int HttpStatusCode { get; private set; }
        public string Title { get; private set; }
    }
}
