using KonusarakOgren.Infrastructure.Data.DataContext;
using KonusarakOgren.Core.Repositories.Interfaces;
using System;
using System.Linq;
using KonusarakOgren.Core.Entities;

namespace KonusarakOgren.Core.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private DatabaseContext _database;

        public AccountRepository(DatabaseContext database)
        {
            _database = database;
        }

        public bool Logi(string username, string password)
        {
            var user = _database.Users.Any(x => x.UserName == username && x.Password == password);
            return user;
        } 
        public User Login(string username, string password)
        {
            var user = _database.Users.FirstOrDefault(x => x.UserName == username && x.Password == password);
            return user;
        }
    }
}
