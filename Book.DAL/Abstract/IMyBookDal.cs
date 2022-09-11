﻿using Book.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.DAL.Abstract
{
    public interface IMyBookDal
    {
        List<MyBook> GetAll();
        MyBook GetById(int id);
        void Add(MyBook myBook);
        void Update(MyBook myBook);
        void Delete (MyBook myBook);

    }
}
