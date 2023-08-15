using Shared.Models;

namespace Shared.Services
{
    public interface IRatingService
    {
        public Task<RatingDto> SearchRating(Guid userId, Guid productId);
        public Task<RatingDto> CreateRating(RatingDto rating);
        public Task<RatingDto> UpdateRating(RatingDto rating);
        public Task RemoveRating(Guid userId, Guid productId);
    }
}
