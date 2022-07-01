using Core.DataAccess.EfRepositoryBase;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfRoleDAL : EfEntityRepositoryBase<RecipeBlogDbContext, Role>, IRoleDAL
    {
    }
}
