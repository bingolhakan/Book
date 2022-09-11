using Book.DAL.Abstract;
using Book.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Book.DAL.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Delete(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return _context.Categories.Where(x=>x.IsDelete!=true).ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public void Update(Category category)
        {
            var result = _context.Categories.Find(category.CategoryID);
            if (result!=null)
            {
                result.Name = category.Name;
                _context.SaveChanges();
            }
        }
    }
}
