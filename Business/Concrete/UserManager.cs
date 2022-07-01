using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDAL _userDAL = new EfUserDAL();
        public IResult Add(User user)
        {
            _userDAL.Add(user);
            return new SuccesResult("Eklendi.");
        }

        public IResult Delete(User user)
        {
            _userDAL.Delete(user);
            return new SuccesResult("Silindi.");
        }

        public IDataResult<List<User>> GetAll()
        {
            var result = _userDAL.GetAll();
            return new SuccesDataResult<List<User>>(result);
        }

        public IDataResult<User> GetById(int Id)
        {
            var result = _userDAL.Get(u => u.Id == Id);
            return new SuccesDataResult<User>(result);
        }

        public IResult Update(User user)
        {
            _userDAL.Update(user);
            return new SuccesResult("Güncellendi.");
        }

        public IDataResult<User> UserControl(string userName, string password)
        {
            var user=_userDAL.GetAll(u => u.UserName == userName && u.Password == password).Single();
            return new SuccesDataResult<User>(user);
        }
    }
}
