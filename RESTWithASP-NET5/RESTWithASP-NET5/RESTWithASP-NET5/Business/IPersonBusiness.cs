using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTWithASP_NET5.Model;

namespace RESTWithASP_NET5.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindById(long Id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);

    }
}
