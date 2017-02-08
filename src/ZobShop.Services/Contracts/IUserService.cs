﻿using System.Collections.Generic;
using ZobShop.Models;

namespace ZobShop.Services.Contracts
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
    }
}