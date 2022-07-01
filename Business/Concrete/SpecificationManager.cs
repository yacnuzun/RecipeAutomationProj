using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SpecificationManager : ISpecificationService
    {
        ISpecificationDAL _specificationDAL = new EfSpecificationDAL();
        public int Add(Specification specification)
        {
            _specificationDAL.Add(specification);
            return specification.Id;
        }

        public IResult Delete(Specification specification)
        {
            _specificationDAL.Delete(specification);
            return new SuccesResult("Silindi.");
        }

        public IDataResult<List<Specification>> GetAll()
        {
            var result=_specificationDAL.GetAll();
            return new SuccesDataResult<List<Specification>>(result);
        }

        public IDataResult<Specification> GetById(int Id)
        {
            var result = _specificationDAL.Get(s => s.Id == Id);
            return new SuccesDataResult<Specification>(result);
        }

        public IDataResult<List<SpecificationMaterialDto>> GetByMetarialDetailAll(int id)
        {
            return new SuccesDataResult<List<SpecificationMaterialDto>>(_specificationDAL.GetSpecificationMaterialDetailAll(id));
            
        }

        public IDataResult<List<SpecificationDetailDto>> GetBySpecificationDetailAll(int id)
        {
            return new SuccesDataResult<List<SpecificationDetailDto>>(_specificationDAL.GetSpecificationDetailAll(id));

        }

        public IDataResult<List<SpecificationDetailDto>> GetBySpecificationDetailsAll()
        {
            return new SuccesDataResult<List<SpecificationDetailDto>>(_specificationDAL.GetSpecificationDetailsAll());
        }

        public IDataResult<List<SpecificationDetailDto>> GetSpecifacationByCategory(int id)
        {
            return new SuccesDataResult<List<SpecificationDetailDto>>(_specificationDAL.GetSpecificationDetailByCategoryId(id));
        }

        public IResult Update(Specification specification)
        {
            _specificationDAL.Update(specification);
            return new SuccesResult("Güncellendi.");
        }
    }
}
