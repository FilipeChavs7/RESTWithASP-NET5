using RESTWithASP_NET5.Data.VO;
using RESTWithASP_NET5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTWithASP_NET5.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
    }
}
