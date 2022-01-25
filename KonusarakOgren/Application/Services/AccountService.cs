
using KonusarakOgren.Application.Interfaces;
using KonusarakOgren.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgren.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public bool Login(string username, string password)
        {
            return _accountRepository.Login(username, password);   
        }
    }
}
