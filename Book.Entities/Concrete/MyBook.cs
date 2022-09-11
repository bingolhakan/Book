using Book.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Entities.Concrete
{
    public class MyBook : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public bool IsDelete { get; set; }
        public int CategoryID { get; set; }
        public Category category { get; set; }
        public int AuthorID { get; set; }
        public Author author { get; set; }
        public int PublisherID { get; set; }
        public Publisher publisher { get; set; }

    }
}
