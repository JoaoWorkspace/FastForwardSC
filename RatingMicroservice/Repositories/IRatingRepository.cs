using FastForwardSC.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingMicroservice.Repositories
{
    public interface IRatingRepository
    {
        public Task<Rating> GetById(Guid ratingId);
        public Task<Rating> CreateRating(Rating rating);
        public Task<Rating> UpdatateRating(Rating rating);
        public Task RemoveRating(Guid ratingId);
    }
}
