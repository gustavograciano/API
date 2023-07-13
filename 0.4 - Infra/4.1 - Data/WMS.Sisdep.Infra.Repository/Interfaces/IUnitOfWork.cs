namespace WMS.Sisdep.Infra.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        Task Commit();
        void RollBack();
    }
}
