using Azima1Books.DataAccess.Data;

namespace Azima1Books.DataAccess.Repository
{
    internal class Repository<T>
    {
        public Repository(ApplicationDbContext db)
        {
        }

        public void Update(Data.Category category)
        {
            throw new NotImplementedException();
        }
    }
}