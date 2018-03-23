using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tolooco.Data.DatabaseContext;
using Tolooco.Data.Infrastructure;
using Tolooco.Entity.Models;

namespace Tolooco.Data.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        IList<User> GetActiveUsers();

    }
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly DbContext db;
        public UserRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (EntiryDb)db);
        }

        public IList<User> GetActiveUsers()
        {
            var Users = GetAll().Where(user => user.IsActive == true)
                .Where(user=>user.IsDeleted==false)
                .ToList();
            return Users;

        }
    }
}
