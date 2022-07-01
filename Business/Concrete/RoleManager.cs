using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        IRoleDAL _roleDAL = new EfRoleDAL();
        public IResult Add(Role role)
        {
            _roleDAL.Add(role);
            return new SuccesResult("Eklendi.");
        }

        public IResult Delete(Role role)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Role>> GetAll()
        {
            var result = _roleDAL.GetAll();
            return new SuccesDataResult<List<Role>>(result);
        }

        public IDataResult<Role> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Role role)
        {
            throw new NotImplementedException();
        }
    }
}
