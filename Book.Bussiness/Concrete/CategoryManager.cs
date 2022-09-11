using Book.Bussiness.Abstract;
using Book.DAL.Concrete.EntityFramework;
using Book.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Bussiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryDal _categoryDal = new EfCategoryDal();
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryID)
        {
            return _categoryDal.GetById(categoryID);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
