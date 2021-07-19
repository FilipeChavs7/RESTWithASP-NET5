using RESTWithASP_NET5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTWithASP_NET5.Business
{
    interface IBookBusiness
    {
        Book Create(Book person);
        Book FindById(long Id);
        List<Book> FindAll();
        Book Update(Book person);
        void Delete(long id);
    }
}
