using Core.DataAccess.EfRepositoryBase;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class EfSpecificationDAL : EfEntityRepositoryBase<RecipeBlogDbContext, Specification>, ISpecificationDAL
    {
        public List<SpecificationDetailDto> GetSpecificationDetailAll(int id)
        {
            using (RecipeBlogDbContext context = new RecipeBlogDbContext())
            {
                var result = (from s in context.Specifications.Where(s=>s.Id==id)
                              join c in context.Categories
                              on s.CategoryId equals c.Id
                              join sm in context.SpecificationMaterials
                              on s.Id equals sm.SpecificationId
                              select new SpecificationDetailDto()
                              {
                                  SpecificationId = s.Id,
                                  Description = s.Description,
                                  Category = c.CategoryName,
                                  MaterialList = s.SpecificationMaterial,
                                  Image = s.Image,
                                  DateTime = s.DateTime.ToLocalTime(),
                              }).ToList();
                return result;
            }
        }

        public List<SpecificationDetailDto> GetSpecificationDetailByCategoryId(int id)
        {
            using (RecipeBlogDbContext context = new RecipeBlogDbContext())
            {
                var result = (from s in context.Specifications.Where(s => s.CategoryId == id)
                              join c in context.Categories
                              on s.CategoryId equals c.Id
                              join sm in context.SpecificationMaterials
                              on s.Id equals sm.SpecificationId
                              select new SpecificationDetailDto()
                              {
                                  SpecificationId = s.Id,
                                  Description = s.Description,
                                  Category = c.CategoryName,
                                  MaterialList = s.SpecificationMaterial,
                                  Image = s.Image,
                                  DateTime = s.DateTime.ToLocalTime(),
                              }).ToList();
                return result;
            }
        }

        public List<SpecificationDetailDto> GetSpecificationDetailsAll()
        {
            using (RecipeBlogDbContext context = new RecipeBlogDbContext())
            {
                var result = (from s in context.Specifications
                              join c in context.Categories
                              on s.CategoryId equals c.Id
                              join sm in context.SpecificationMaterials
                              on s.Id equals sm.SpecificationId
                              select new SpecificationDetailDto()
                              {
                                  SpecificationId = s.Id,
                                  Description = s.Description,
                                  Category = c.CategoryName,
                                  MaterialList = s.SpecificationMaterial,
                                  Image = s.Image,
                                  DateTime = s.DateTime.ToLocalTime(),
                              }).ToList();
                return result;
            }
        }

        public List<SpecificationMaterial> GetSpecificationMaterialAll(int id)
        {
            using (RecipeBlogDbContext context = new RecipeBlogDbContext())
            {
                var result = (from sm in context.SpecificationMaterials
                              join s in context.Specifications.Where(s=>s.Id==id)
                              on sm.SpecificationId equals s.Id
                              join m in context.Materials
                              on sm.MaterialId equals m.Id
                              select new SpecificationMaterial()
                              {
                                  SpecificationId = s.Id,
                                  MaterialId = m.Id,
                                  Slug = sm.Slug,
                                  Gauger = sm.Gauger
                              }).ToList();
                return result;

            }
        }

        public List<SpecificationMaterialDto> GetSpecificationMaterialDetailAll(int id)
        {
            using (RecipeBlogDbContext context = new RecipeBlogDbContext())
            {
                var result = (from sm in context.SpecificationMaterials
                              join s in context.Specifications.Where(s=>s.Id==id)
                              on sm.SpecificationId equals s.Id
                              join m in context.Materials
                              on sm.MaterialId equals m.Id
                              select new SpecificationMaterialDto()
                              {
                                  SpecificationId = s.Id,
                                  Specification = s.Description,
                                  Material = m.MaterialName,
                                  Slug = sm.Slug,
                                  Gauger = sm.Gauger
                              }).ToList();
                return result;

            }
        }
    }
}


