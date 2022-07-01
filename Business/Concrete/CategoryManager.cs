using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL = new EfCategoryDAL();
        public IResult Add(Category category)
        {
            _categoryDAL.Add(category);
            return new SuccesResult("Eklendi.");
        }

        public IResult Delete(Category category)
        {
            _categoryDAL.Delete(category);
            return new SuccesResult("Silindi.");
        }

        public IDataResult<List<Category>> GetAll()
        {
            var result = _categoryDAL.GetAll();
            return new SuccesDataResult<List<Category>>(result);
        }

        public IDataResult<Category> GetById(int Id)
        {
            return new SuccesDataResult<Category>(_categoryDAL.Get(c => c.Id == Id));
        }

        public IResult Update(Category category)
        {
            _categoryDAL.Update(category);
            return new SuccesResult("Güncellendi.");
        }
    }
}
