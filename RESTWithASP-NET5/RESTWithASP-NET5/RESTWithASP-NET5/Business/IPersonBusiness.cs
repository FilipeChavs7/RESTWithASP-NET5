using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTWithASP_NET5.Data.VO;
using RESTWithASP_NET5.Hypermedia.Utils;
using RESTWithASP_NET5.Model;

namespace RESTWithASP_NET5.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long Id);
        List<PersonVO> FindByName(string firstName, string lastName);
        List<PersonVO> FindAll();
        PagedSearchVO<PersonVO> FindWithPàgedSearch(
            string name, string sortDirection, int pageSize, int page);
        PersonVO Update(PersonVO person);
        PersonVO Disable(long id);
        void Delete(long id);

    }
}
