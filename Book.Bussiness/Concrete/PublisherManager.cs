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
    public class PublisherManager : IPublisherService
    {
        EfPublisherDal _publisherDal = new EfPublisherDal();
        public void Add(Publisher publisher)
        {
            _publisherDal.Add(publisher);
        }

        public void Delete(Publisher publisher)
        {
            _publisherDal.Delete(publisher);
        }

        public List<Publisher> GetAll()
        {
            return _publisherDal.GetAll();
        }

        public Publisher GetById(int id)
        {
            return _publisherDal.GetById(id);
        }

        public void Update(Publisher publisher)
        {
            _publisherDal.Update(publisher);
        }
    }
}
