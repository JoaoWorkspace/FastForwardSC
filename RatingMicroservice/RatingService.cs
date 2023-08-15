using FastForwardSC.Persistence.Models;
using Shared.Models;
using Shared.Services;

namespace RatingMicroservice
{
    public class RatingService : IRatingService
    {
        public async Task<List<RatingDto>> GetAllRatingsByProduct(Guid productId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<RatingDto>> GetAllRatingsByUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<RatingDto> SearchRating(Guid userId, Guid productId)
        {
            throw new NotImplementedException();
        }

        public async Task<RatingDto> CreateRating(RatingDto rating)
        {
            throw new NotImplementedException();
        }

        public async Task<RatingDto> UpdateRating(RatingDto rating)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveRating(Guid userId, Guid productId)
        {
            throw new NotImplementedException();
        }
    }
}