﻿using Dbmodel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IUserService
    {
        Task<IEnumerable<getUserListData>> getUserListData();
    }
}
