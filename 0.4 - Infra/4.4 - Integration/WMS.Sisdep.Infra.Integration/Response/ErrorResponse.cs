namespace WMS.Sisdep.Infra.Integration.Response
{
    public class ErrorResponse
    {
        public Error Errors { get; set; }
    }
    public class Error
    {
        public int Status { get; set; }
        public string? Title { get; set; }
        public string? Detail { get; set; }
    }
}
