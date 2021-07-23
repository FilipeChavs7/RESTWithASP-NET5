﻿using RESTWithASP_NET5.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTWithASP_NET5.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidateCredentials(UserVO user); 
        TokenVO ValidateCredentials(TokenVO token);
        bool RevokeToken(string username);
    }
}
