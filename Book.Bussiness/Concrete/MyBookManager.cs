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
    public class MyBookManager : IMyBookService
    {
        EfMyBookDal _myBookDal = new EfMyBookDal();
        public void Add(MyBook myBook)
        {
            _myBookDal.Add(myBook);
        }

        public void Delete(MyBook myBook)
        {
            _myBookDal.Delete(myBook);
        }

        public List<MyBook> GetAll()
        {
            return _myBookDal.GetAll();
        }

        public MyBook GetById(int id)
        {
            return _myBookDal.GetById(id);
        }

        public void Update(MyBook myBook)
        {
            _myBookDal.Update(myBook);
        }
    }
}
