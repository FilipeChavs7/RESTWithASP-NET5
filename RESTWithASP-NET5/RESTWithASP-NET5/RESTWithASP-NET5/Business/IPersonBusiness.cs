using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTWithASP_NET5.Data.VO;
using RESTWithASP_NET5.Model;

namespace RESTWithASP_NET5.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long Id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);

    }
}
