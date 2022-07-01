using Core.DataAccess.EfRepositoryBase;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfCategoryDAL:EfEntityRepositoryBase<RecipeBlogDbContext,Category>,ICategoryDAL
    {
    }
}
