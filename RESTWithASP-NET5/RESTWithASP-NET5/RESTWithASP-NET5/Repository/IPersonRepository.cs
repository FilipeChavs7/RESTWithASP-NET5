using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTWithASP_NET5.Model;

namespace RESTWithASP_NET5.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindById(long Id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
        bool Exists(long id);
    }
}
