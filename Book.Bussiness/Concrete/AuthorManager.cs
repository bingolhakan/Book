﻿using Book.Bussiness.Abstract;
using Book.DAL.Concrete.EntityFramework;
using Book.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Bussiness.Concrete
{
    public class AuthorManager : IAuthorService
    {
        EfAuthorDal _authorDal = new EfAuthorDal();
        public void Add(Author author)
        {
            _authorDal.Add(author);
        }

        public void Delete(Author author)
        {
            _authorDal.Delete(author);
        }

        public List<Author> GetAll()
        {
            return _authorDal.GetAll();
        }

        public Author GetById(int id)
        {
            return _authorDal.GetById(id);
        }

        public void Update(Author author)
        {
            _authorDal.Update(author);
        }
    }
}
