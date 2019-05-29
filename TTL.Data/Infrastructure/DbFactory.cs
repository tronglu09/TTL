namespace TTL.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TTLDbContext dbContext;

        public TTLDbContext Init()
        {
            return dbContext ?? (dbContext = new TTLDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}