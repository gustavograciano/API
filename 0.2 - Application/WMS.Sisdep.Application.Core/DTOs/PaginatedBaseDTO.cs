namespace WMS.Sisdep.Application.Core.DTOs
{
    public class PaginatedBaseDTO<T>
    {
        public int Pages { get; set; }
        public int Page { get; set; }
        public int Total { get; set; }
        public List<T>? Data { get; set; }
    }
}
