using KonusarakOgren.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgren.Core.Repositories.Interfaces
{
    public interface IAccountRepository
    {
        bool Logi(string username, string password);
        User Login(string username, string password);
    }
}
