using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRoleService
    {
        IDataResult<List<Role>> GetAll();
        IDataResult<Role> GetById(int Id);
        IResult Add(Role role);
        IResult Update(Role role);
        IResult Delete(Role role);
    }
}
