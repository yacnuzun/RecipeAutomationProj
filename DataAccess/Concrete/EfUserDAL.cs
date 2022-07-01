using Core.DataAccess.EfRepositoryBase;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfUserDAL : EfEntityRepositoryBase<RecipeBlogDbContext, User>, IUserDAL
    {
    }
}
