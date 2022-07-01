using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SpecificationMaterialManager : ISpecificationMaterialService
    {
        ISpecificationMaterialDAL _specificationMaterialDAL = new EfSpecificationMaterialDAL();
        public IResult Add(SpecificationMaterial specificationMaterial)
        {
            _specificationMaterialDAL.Add(specificationMaterial);
            return new SuccesResult("Eklendi.");
        }

        public IResult Delete(SpecificationMaterial specificationMaterial)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SpecificationMaterial>> GetAll()
        {
            var result = _specificationMaterialDAL.GetAll();
            return new SuccesDataResult<List<SpecificationMaterial>>(result);
        }

        public IDataResult<List<SpecificationMaterial>> GetAllBySpecificationId(int Id)
        {
            return new SuccesDataResult<List<SpecificationMaterial>>(_specificationMaterialDAL.GetAll(sm => sm.SpecificationId == Id));

        }

        public IDataResult<SpecificationMaterial> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(SpecificationMaterial specificationMaterial)
        {
            throw new NotImplementedException();
        }

    }
}
