using Book.DAL.Abstract;
using Book.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.DAL.Concrete.EntityFramework
{
    public class EfMyBookDal : IMyBookDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(MyBook myBook)
        {
            _context.Mybooks.Add(myBook);
            _context.SaveChanges();
        }

        public void Delete(MyBook myBook)
        {
            _context.Mybooks.Remove(myBook);
            _context.SaveChanges();
        }

        public List<MyBook> GetAll()
        {
            return _context.Mybooks.Where(x=>x.IsDelete!=true).ToList();
        }

        public MyBook GetById(int id)
        {
            return _context.Mybooks.Find(id);
        }

        public void Update(MyBook myBook)
        {
            var result = _context.Mybooks.Find(myBook.ID);
            if (result!=null)
            {
                result.Name = myBook.Name;
                result.ISBN = myBook.ISBN;
                result.author = myBook.author;
                result.publisher = myBook.publisher;
                result.category = myBook.category;
                _context.SaveChanges();

            }
        }
    }
}
