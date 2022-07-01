using Core.DataAccess;
using Entities.Concrete;
using Entities.DTO_s;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface ISpecificationDAL : IEntityRepository<Specification>
    {
        List<SpecificationDetailDto> GetSpecificationDetailAll(int id);
        List<SpecificationDetailDto> GetSpecificationDetailsAll();

        List<SpecificationDetailDto> GetSpecificationDetailByCategoryId(int id);

        List<SpecificationMaterial> GetSpecificationMaterialAll(int id);

        List<SpecificationMaterialDto> GetSpecificationMaterialDetailAll(int id);
    }
}
