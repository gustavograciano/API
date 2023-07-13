namespace WMS.Sisdep.Domain.Core.Queries
{
    public class PaginatedBaseQuery
    {
        public int Page { get; set; } = 1;
        public int Quantity { get; set; } = 5;
    }
}
