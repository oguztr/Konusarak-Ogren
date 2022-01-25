using KonusarakOgren.Infrastructure.Data.DataContext;
using KonusarakOgren.Core.Repositories.Interfaces;
using System;
using System.Linq;

namespace KonusarakOgren.Core.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private DatabaseContext _database;

        public AccountRepository(DatabaseContext database)
        {
            _database = database;
        }

        public bool Login(string username, string password)
        {
            var user = _database.Users.Any(x => x.UserName == username && x.Password == password);
            return user;
        }
    }
}
