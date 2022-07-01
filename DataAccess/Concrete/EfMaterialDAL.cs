using Core.DataAccess.EfRepositoryBase;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfMaterialDAL : EfEntityRepositoryBase<RecipeBlogDbContext, Material>, IMaterialDAL
    {

    }
}
