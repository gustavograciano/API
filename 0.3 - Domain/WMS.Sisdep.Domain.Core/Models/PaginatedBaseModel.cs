namespace WMS.Sisdep.Domain.Core.Models
{
    public class PaginatedBaseModel<T>
    {
        public int Pages { get; set; }
        public int Page { get; set; }
        public int Total { get; set; }
        public List<T>? Data { get; set; }
    }
}
