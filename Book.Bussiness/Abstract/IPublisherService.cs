﻿using Book.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Bussiness.Abstract
{
    public interface IPublisherService
    {
        List<Publisher> GetAll();
        Publisher GetById(int id);
        void Add(Publisher publisher);
        void Update(Publisher publisher);
        void Delete(Publisher publisher);

    }
}
