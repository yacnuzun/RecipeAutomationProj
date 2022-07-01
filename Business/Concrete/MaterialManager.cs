using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class MaterialManager : IMaterialService
    {
        IMaterialDAL _materialDAL = new EfMaterialDAL();
        public IResult Add(Material material)
        {
            _materialDAL.Add(material);
            return new SuccesResult("Eklendi.");
        }

        public IResult Delete(Material material)
        {
            _materialDAL.Delete(material);
            return new SuccesResult("Silindi.");
        }

        public IDataResult<List<Material>> GetAll()
        {
            var result = _materialDAL.GetAll();
            return new SuccesDataResult<List<Material>>(result);
        }

        public IDataResult<Material> GetById(int Id)
        {
           return new SuccesDataResult<Material>(_materialDAL.Get(m=>m.Id==Id));
        }

        public IResult Update(Material material)
        {
            _materialDAL.Update(material);
            return new SuccesResult("Güncellendi.");
        }
    }
}
