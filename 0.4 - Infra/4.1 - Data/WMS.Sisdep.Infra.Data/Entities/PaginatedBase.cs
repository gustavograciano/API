using Microsoft.EntityFrameworkCore;

namespace WMS.Sisdep.Infra.Data.Entities
{
    public class PaginatedBase<TEntity> : List<TEntity> where TEntity : class
    {
        public int Pages { get; private set; }
        public int Page { get; private set; }
        public int Total { get; private set; }
        public List<TEntity> Data { get; private set; }

        private PaginatedBase(List<TEntity> items, int total, int page, int quantity)
        {
            Page = page;
            Pages = (int)Math.Ceiling(total / (double)quantity);
            Total = total;
            Data = items;
            this.AddRange(items);
        }

        public static async Task<PaginatedBase<TEntity>> CreateAsync(IQueryable<TEntity> source, int page, int quantity)
        {
            page = page == 0 ? 1 : page;
            quantity = quantity == 0 ? 10 : quantity;

            int total = await source.CountAsync();

            List<TEntity> items = await source
                .Skip((page - 1) * quantity)
                .Take(quantity)
                .ToListAsync();

            return new PaginatedBase<TEntity>(items, total, page, quantity);
        }
    }
}
