using KonusarakOgren.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgren.Application.Interfaces
{
    public interface IAccountService
    {
        bool Logi(string username, string password);
        User Login(string username, string password);
    }
}
