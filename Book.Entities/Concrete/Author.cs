using Book.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Entities.Concrete
{
    public class Author : IEntity
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public bool IsDelete { get; set; }
        public IEnumerable<MyBook> Books { get; set; }
    }
}
