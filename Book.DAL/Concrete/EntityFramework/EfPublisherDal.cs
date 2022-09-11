using Book.DAL.Abstract;
using Book.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.DAL.Concrete.EntityFramework
{
    public class EfPublisherDal : IPublisher
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Publisher publisher)
        {
            _context.Publishers.Add(publisher);
            _context.SaveChanges();
        }

        public void Delete(Publisher publisher)
        {
            _context.Publishers.Remove(publisher);
        }

        public List<Publisher> GetAll()
        {
            return _context.Publishers.Where(x=>x.IsDelete!=true ).ToList();
        }

        public Publisher GetById(int id)
        {
            return _context.Publishers.Find(id);
        }

        public void Update(Publisher publisher)
        {
            var result = _context.Publishers.Find(publisher.PublisherID);
            if (result!=null)
            {
                result.Name = publisher.Name;
                _context.SaveChanges();
            }
        }
    }
}
