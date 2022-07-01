using Core.DataAccess.EfRepositoryBase;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfSpecificationMaterialDAL : EfEntityRepositoryBase<RecipeBlogDbContext, SpecificationMaterial>, ISpecificationMaterialDAL
    {
    }
}
