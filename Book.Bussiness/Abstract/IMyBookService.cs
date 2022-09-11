using Book.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Bussiness.Abstract
{
    public interface IMyBookService
    {
        List<MyBook> GetAll();
        MyBook GetById(int id);
        void Add(MyBook myBook);
        void Update(MyBook myBook);
        void Delete(MyBook myBook);

    }
}
