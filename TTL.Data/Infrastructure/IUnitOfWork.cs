namespace TTL.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}