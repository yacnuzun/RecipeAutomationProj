using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int Id);
        IDataResult<User> UserControl(string userName,string password);

        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
