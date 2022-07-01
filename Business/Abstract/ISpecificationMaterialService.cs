using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISpecificationMaterialService
    {
        IDataResult<List<SpecificationMaterial>> GetAll();
        IDataResult<List<SpecificationMaterial>> GetAllBySpecificationId(int Id);

        IDataResult<SpecificationMaterial> GetById(int Id);
        IResult Add(SpecificationMaterial specificationMaterial);
        IResult Update(SpecificationMaterial specificationMaterial);
        IResult Delete(SpecificationMaterial specificationMaterial);
    }
}
