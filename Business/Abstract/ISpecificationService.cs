using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISpecificationService
    {
        IDataResult<List<Specification>> GetAll();
        IDataResult<List<SpecificationDetailDto>> GetSpecifacationByCategory(int id);

        IDataResult<List<SpecificationDetailDto>> GetBySpecificationDetailAll(int id);
        IDataResult<List<SpecificationDetailDto>> GetBySpecificationDetailsAll();
        IDataResult<List<SpecificationMaterialDto>> GetByMetarialDetailAll(int id);

        IDataResult<Specification> GetById(int Id);
        int Add(Specification specification);
        IResult Update(Specification specification);
        IResult Delete(Specification specification);
    }
}
