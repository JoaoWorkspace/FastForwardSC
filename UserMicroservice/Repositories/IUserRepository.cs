using FastForwardSC.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMicroservice.Repositories
{
    public interface IUserRepository
    {
        public Task<User> GetById(Guid userId);
        public Task<User> CreateUser(User user);
        public Task<User> UpdateUser(User user);
        public Task RemoveUser(Guid userId);
    }
}
