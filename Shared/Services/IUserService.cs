using Shared.Models;

namespace Shared.Services
{
    public interface IUserService
    {
        public Task<UserDto> SearchUser(Guid userId);
        public Task<UserDto> CreateUser(UserDto user);
        public Task<UserDto> UpdateUser(UserDto user);
        public Task RemoveUser(Guid userId);
    }
}
