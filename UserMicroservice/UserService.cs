using AutoMapper;
using FastForwardSC.Persistence.Models;
using Microsoft.Extensions.Logging;
using Shared.Models;
using Shared.Services;
using System.Text;
using UserMicroservice.Repositories;

namespace UserMicroservice
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        private readonly ILogger<UserService> logger;

        public UserService(IUserRepository userRepository, IMapper mapper, ILogger<UserService> logger) 
        { 
            this.userRepository = userRepository;
            this.mapper = mapper;
            this.logger = logger;
        }
        public async Task<UserDto> SearchUser(Guid userId)
        {
            var user = await this.userRepository.GetById(userId);
            var result = mapper.Map<UserDto>(user);
            return result;
        }

        public async Task<UserDto> CreateUser(UserDto user)
        {
            try
            {
                var sha1 = System.Security.Cryptography.SHA1.Create();
                var encryptedPasswordBytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(user.Password.ToCharArray()));

                User creatingUser = new User();
                creatingUser.Username = user.Username;
                creatingUser.Password = Convert.ToBase64String(encryptedPasswordBytes);
                creatingUser.Email = user.Email;

                var createdUser = await userRepository.CreateUser(creatingUser);
                var result = mapper.Map<UserDto>(createdUser);
                return result;
            }catch(Exception ex)
            {
                logger.LogError(ex.Message, ex);
                return null;
            }
     
        }

        public async Task<UserDto> UpdateUser(UserDto user)
        {
            try
            {
                var existingUser = await userRepository.GetById(user.UserId);
                existingUser.Username = user.Username;
                existingUser.Email = user.Email;

                var updatedUser = await userRepository.UpdateUser(existingUser);
                var result = mapper.Map<UserDto>(updatedUser);
                return result;
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex);
                return null;
            }

        }

        public async Task RemoveUser(Guid userId)
        {
            await userRepository.RemoveUser(userId);
        }

    }
}