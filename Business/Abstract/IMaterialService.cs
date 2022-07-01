using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IMaterialService
    {
        IDataResult<List<Material>> GetAll();
        IDataResult<Material> GetById(int Id);
        IResult Add(Material material);
        IResult Update(Material material);
        IResult Delete(Material material);
    }
}
