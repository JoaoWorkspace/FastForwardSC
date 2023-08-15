using AutoMapper;
using FastForwardSC.Persistence;
using FastForwardSC.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace UserMicroservice.Repositories
{
    public class UserRepository : IUserRepository
    {
        protected readonly ShoppingContext context;
        private readonly IMapper mapper;

        public UserRepository(ShoppingContext context, IMapper mapper) 
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<User> GetById(Guid userId)
        {
            return await context.Users.SingleOrDefaultAsync(user => user.UserId.Equals(userId));
        }

        public async Task<User> CreateUser(User user)
        {
            await this.context.Users.AddAsync(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateUser(User user)
        {
            var userToUpdate = await context.Users.Include(u => u.UserRatings).Include(u => u.UserCart).Include(u => u.UserOrderHistory).SingleOrDefaultAsync(u => u.UserId == user.UserId);
            userToUpdate.Username = user.Username;
            userToUpdate.Email = user.Email;
            await context.SaveChangesAsync();
            return userToUpdate;
        }

        public async Task RemoveUser(Guid userId)
        {
            var userToRemove = await context.Users.Include(u => u.UserRatings).Include(u => u.UserCart).Include(u => u.UserOrderHistory).SingleOrDefaultAsync(u => u.UserId == userId);
            context.Users.Remove(userToRemove);
            await context.SaveChangesAsync();
        }

    }
}
